var swiper = new Swiper(".swiper", {
  //centeredSlides: true,
  //  loop: true,
  //  freeMode: true,
  grabCursor: true,
  navigation: {
    nextEl: ".swiper-button-next",
    prevEl: ".swiper-button-prev",
  },

  breakpoints: {
    640: {
      slidesPerView: 2,
      spaceBetween: 20,
    },
    768: {
      slidesPerView: 4,
      spaceBetween: 40,
    },
    1024: {
      slidesPerView: 6,
      spaceBetween: 20,
    },
  },
});

var swiperCoach = new Swiper(".swiperCoach", {
  //centeredSlides: true,
  //  loop: true,
  //  freeMode: true,
  grabCursor: true,
  navigation: {
    nextEl: ".swiper-button-next",
    prevEl: ".swiper-button-prev",
  },
  breakpoints: {
    400: {
      slidesPerView: 1,
      spaceBetween: 20,
    },
    640: {
      slidesPerView: 2,
      spaceBetween: 20,
    },
    768: {
      slidesPerView: 3,
      spaceBetween: 30,
    },
    1024: {
      slidesPerView: 4,
      spaceBetween: 50,
    },
  },
});

var swiperCoachV2 = new Swiper(".swiperCoachV2", {
  //centeredSlides: true,
  //  loop: true,
  //  freeMode: true,
  grabCursor: true,
  navigation: {
    nextEl: ".swiper-button-next",
    prevEl: ".swiper-button-prev",
  },
  breakpoints: {
    400: {
      slidesPerView: 1,
      spaceBetween: 20,
    },
    640: {
      slidesPerView: 1,
      spaceBetween: 20,
    },
    768: {
      slidesPerView: 2,
      spaceBetween: 30,
    },
    1024: {
      slidesPerView: 3,
      spaceBetween: 30,
    },
  },
});

var swiperMeals = new Swiper(".swiperMeals", {
  // effect: "cards",
  grabCursor: true,
  spaceBetween: 30,
  loop: true,
  autoplay: true,
  slidesPerView: 1,

  speed: 200,
  navigation: {
    nextEl: ".swiper-button-next",
    prevEl: ".swiper-button-prev",
  },
  pagination: {
    el: ".swiper-pagination",
  },
});

var swiperMealsV2 = new Swiper(".swiperMealsV2", {
  // effect: "cards",
  grabCursor: true,
  spaceBetween: 50,
  loop: true,
  autoplay: true,
  slidesPerView: 1,
  //   centeredSlides: true,
  speed: 200,
  navigation: {
    nextEl: ".swiper-button-next",
    prevEl: ".swiper-button-prev",
  },
  pagination: {
    el: ".swiper-pagination",
  },
});

var swiperV2 = new Swiper(".sv2", {
  //centeredSlides: true,
  //  loop: true,
  //  freeMode: true,
  grabCursor: true,
  navigation: {
    nextEl: ".swiper-button-next",
    prevEl: ".swiper-button-prev",
  },

  breakpoints: {
    640: {
      slidesPerView: 2,
      spaceBetween: 30,
    },
    1024: {
      slidesPerView: 4,
      spaceBetween: 40,
    },
  },
});
