function RenderPagination(JsonData) {
    Paging.firstElementChild.innerHTML = "";
    let perv = JsonData.previousPage === null ? "d-none" : "";
    let next = JsonData.nextPage === null ? "d-none" : "";
    var first = (CurPage != 1 && JsonData.totalPages != 0) ? "" : "d-none";
    var last = (CurPage != JsonData.totalPages && JsonData.totalPages != 0) ? "" : "d-none";
    var firstIndex = Math.max(CurPage - 2, 1);
    var lastIndex = Math.min(CurPage + 2, JsonData.totalPages);
    let nav = document.createElement("nav");
    nav.setAttribute('aria-label', "Page navigation example")
    let ul = document.createElement("ul");
    ul.className = "pagination m-0";
    nav.appendChild(ul);
    let liFirst = document.createElement("li");
    liFirst.className = "page-item";
    let aFirst = document.createElement("a");
    aFirst.className = "page-link first " + first;
    aFirst.setAttribute('aria-label', "First");
    aFirst.addEventListener("click", () => { CurPage = 1; getdata(null); });
    aFirst.innerHTML = `<i class='bx bx-last-page '></i>`;
    liFirst.appendChild(aFirst);
    let liLast = document.createElement("li");
    liLast.className = "page-item";
    let aLast = document.createElement("a");
    aLast.className = "page-link " + last;
    aLast.setAttribute('aria-label', "Last");
    aLast.addEventListener("click", () => { CurPage = JsonData.totalPages; getdata(null); });
    aLast.innerHTML = `<i class='bx bx-first-page '></i>`;
    liLast.appendChild(aLast);
    let liPer = document.createElement("li");
    liPer.className = "page-item";
    let aPer = document.createElement("a");
    aPer.className = "page-link " + perv;
    aPer.setAttribute('aria-label', "Previous");
    aPer.addEventListener("click", () => { PrevPage(JsonData); });
    aPer.innerHTML = `<i class='bx bx-chevron-right '></i>`;
    liPer.appendChild(aPer);
    let liNext = document.createElement("li");
    liNext.className = "page-item";
    let aNext = document.createElement("a");
    aNext.className = "page-link " + next;
    aNext.setAttribute('aria-label', "Next");
    aNext.addEventListener("click", () => { NextPage(JsonData); });
    aNext.innerHTML = `<i class='bx bx-chevron-left '></i>`;
    liNext.appendChild(aNext);
    let listOfLi = [];
    for (var i = firstIndex; i <= lastIndex; i++) {
        let li = document.createElement("li");
        li.className = "page-item";
        let a = document.createElement("a");
        if (i == CurPage) { a.className = "page-link  active"; }
        else {

            a.className = "page-link";
            a.setAttribute("data-page", i);
            a.addEventListener("click", () => { GetPage(a.getAttribute("data-page")) });

        }
        a.setAttribute('aria-label', "Previous");
        a.innerHTML = i;
        li.appendChild(a);
        listOfLi.push(li);
    }
    ul.appendChild(liFirst);
    ul.appendChild(liPer);

    listOfLi.map(li => ul.appendChild(li))
    ul.appendChild(liNext);
    ul.appendChild(liLast);



    Paging.firstElementChild.appendChild(nav);
}