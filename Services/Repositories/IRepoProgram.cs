namespace liaqati_master.Services.Repositories
{
    public class IRepoProgram
    {
        private readonly LiaqatiDBContext _context;

        public IRepoProgram(LiaqatiDBContext context)
        {
            _context = context;
        }
        public async Task<bool> AddProgram(SportsProgram SportsProgram)
        {
            await _context.TblSportsProgram.AddAsync(SportsProgram);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteProgram(string? id)
        {
            List<SportsProgram> SportsProgram = _context.TblSportsProgram.Include(x => x.Services).Include(p => p.Exercies_Programs).ToList();
            SportsProgram? sport = SportsProgram.FirstOrDefault(p => p.Equals(id));
            if (sport == null) { return false; }
            _context.TblSportsProgram.Remove(sport);
            await _context.SaveChangesAsync();

            return true;
        }



        public async Task<List<SportsProgram>> GetAllProgram()
        {
            List<SportsProgram> SportsProgram = _context.TblSportsProgram.Include(x => x.Services).Include(p => p.Exercies_Programs).ToList();

            return SportsProgram;
        }
        public async Task<SportsProgram> GetProgram(string? id)
        {
            List<SportsProgram> SportsProgram = _context.TblSportsProgram.Include(x => x.Services).Include(p => p.Exercies_Programs).ToList();

            SportsProgram? sport = SportsProgram.FirstOrDefault(p => p.Id.Equals(id));

            await _context.SaveChangesAsync();

            return sport;
        }

        public async Task<bool> UpdateProgram(SportsProgram SportsProgram)
        {
            _context.TblSportsProgram.Update(SportsProgram);
            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<QueryPageResult<SportsProgram>> SearchSportsProgram(SportProgramQueryParamters sportProgramQueryParams)
        {
            IQueryable<SportsProgram> ListOfSportsProgram = (await GetAllProgram()).AsQueryable();
            List<(string, string)>? ListOfSelectedFilters = new();

            if (!string.IsNullOrEmpty(sportProgramQueryParams.SearchTearm))
            {
                ListOfSportsProgram = ListOfSportsProgram.Where(p =>
                    p.Services!.Title!.ToLower().Trim().Contains(sportProgramQueryParams.SearchTearm.ToLower().Trim()) ||
                    p.Services.ShortDescription!.ToLower().Trim().Contains(sportProgramQueryParams.SearchTearm.ToLower().Trim()) ||
                    p.Services.Description!.ToLower().Trim().Contains(sportProgramQueryParams.SearchTearm.ToLower().Trim())
                );
                ListOfSelectedFilters.Add((nameof(sportProgramQueryParams.SearchTearm), sportProgramQueryParams.SearchTearm ?? ""));
            }
            if (sportProgramQueryParams.Length is not null)
            {
                ListOfSportsProgram = ListOfSportsProgram.Where(p => p.Length == sportProgramQueryParams.Length);
                ListOfSelectedFilters.Add((nameof(sportProgramQueryParams.Length), sportProgramQueryParams.Length.ToString() ?? ""));

            }

            if (!string.IsNullOrEmpty(sportProgramQueryParams.Title))
            {
                ListOfSportsProgram = ListOfSportsProgram.Where(p => p.Services!.Title!.ToLower().Trim() == sportProgramQueryParams.Title.ToLower().Trim());
                ListOfSelectedFilters.Add((nameof(sportProgramQueryParams.Title), sportProgramQueryParams.Title.ToString() ?? ""));

            }
            string str = "";
            if (sportProgramQueryParams.MinDuration != null)
            {
                ListOfSportsProgram = ListOfSportsProgram.Where(p => p.Duration >= sportProgramQueryParams.MinDuration);

                ListOfSelectedFilters.Add((nameof(sportProgramQueryParams.MinDuration), sportProgramQueryParams.MinDuration.ToString() ?? "Max"));

            }


            if (sportProgramQueryParams.MaxDuration != null)
            {
                ListOfSportsProgram = ListOfSportsProgram.Where(p => p.Duration <= sportProgramQueryParams.MaxDuration);
                ListOfSelectedFilters.Add((nameof(sportProgramQueryParams.MaxDuration), sportProgramQueryParams.MaxDuration.ToString() ?? "Max"));


            }
            if (sportProgramQueryParams.MinDuration != null && sportProgramQueryParams.MaxDuration != null)
            {
                ListOfSelectedFilters.Add(("Duration", $"{sportProgramQueryParams.MinDuration.ToString() ?? "0"} - {sportProgramQueryParams.MaxDuration.ToString() ?? "Max"}"));
            }
            if (sportProgramQueryParams.BodyFocus is not null)
                if (sportProgramQueryParams.BodyFocus.Count != 0)
                {
                    List<SportsProgram> ListOfSportsPrograms = new();

                    foreach (var item in sportProgramQueryParams.BodyFocus)
                    {
                        if (item is not null)
                        {

                            ListOfSportsPrograms.AddRange(ListOfSportsProgram.Where(p => p.BodyFocus!.ToLower().Trim().Contains(item.ToLower().Trim())));
                            ListOfSelectedFilters.Add((nameof(sportProgramQueryParams.BodyFocus), item.ToString() ?? ""));

                        }
                    }
                    ListOfSportsProgram = ListOfSportsPrograms.AsQueryable();

                }
            if (sportProgramQueryParams.TraningType is not null)
                if (sportProgramQueryParams.TraningType.Count != 0)
                {
                    List<SportsProgram> ListOfSportsPrograms = new();

                    foreach (var item in sportProgramQueryParams.TraningType)
                    {
                        if (item is not null)
                        {

                            ListOfSportsPrograms.AddRange(ListOfSportsProgram.Where(p => p.TrainingType!.ToLower().Trim().Contains(item.ToLower().Trim())));
                            ListOfSelectedFilters.Add((nameof(sportProgramQueryParams.TraningType), item.ToString() ?? ""));

                        }
                    }
                    ListOfSportsProgram = ListOfSportsPrograms.AsQueryable();

                }
            if (sportProgramQueryParams.Difficulty is not null)
                if (sportProgramQueryParams.Difficulty.Count != 0)
                {
                    List<SportsProgram> ListOfSportsPrograms = new();

                    foreach (var item in sportProgramQueryParams.Difficulty)
                    {
                        if (item.ToString() is not null)
                        {

                            ListOfSportsPrograms.AddRange(ListOfSportsProgram.Where(p => p.Difficulty!.ToString()!.ToLower().Trim().Contains(item.ToString().ToLower().Trim())));
                            ListOfSelectedFilters.Add((nameof(sportProgramQueryParams.Difficulty), item.ToString() ?? ""));
                        }
                    }
                    ListOfSportsProgram = ListOfSportsPrograms.AsQueryable();

                }
            if (sportProgramQueryParams.Equipment is not null)
                if (sportProgramQueryParams.Equipment.Count != 0)
                {
                    List<SportsProgram> ListOfSportsPrograms = new();
                    foreach (var item in sportProgramQueryParams.Equipment)
                    {
                        if (item is not null)
                        {

                            ListOfSportsPrograms.AddRange(ListOfSportsProgram.Where(p => p.Equipment!.ToLower().Trim().Contains(item.ToLower().Trim())));

                            ListOfSelectedFilters.Add((nameof(sportProgramQueryParams.Difficulty), item.ToString() ?? ""));
                        }
                    }
                    ListOfSportsProgram = ListOfSportsPrograms.AsQueryable();
                }

            if (!string.IsNullOrEmpty(sportProgramQueryParams.SortBy))
            {
                if (sportProgramQueryParams.SortBy.Equals(nameof(Service.Title), StringComparison.OrdinalIgnoreCase))
                {
                    if (sportProgramQueryParams.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        ListOfSportsProgram = ListOfSportsProgram.OrderBy(p => p.Services!.Title);
                    else if (sportProgramQueryParams.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        ListOfSportsProgram = ListOfSportsProgram.OrderByDescending(p => p.Services!.Title);

                }
                else if (sportProgramQueryParams.SortBy.Equals(nameof(Service.Price), StringComparison.OrdinalIgnoreCase))
                {
                    if (sportProgramQueryParams.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        ListOfSportsProgram = ListOfSportsProgram.OrderBy(p => p.Services!.Price);
                    else if (sportProgramQueryParams.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        ListOfSportsProgram = ListOfSportsProgram.OrderByDescending(p => p.Services!.Price);

                }
                else if (sportProgramQueryParams.SortBy.Equals(nameof(SportsProgram.Difficulty), StringComparison.OrdinalIgnoreCase))
                {
                    if (sportProgramQueryParams.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        ListOfSportsProgram = ListOfSportsProgram.OrderBy(p => p.Difficulty);
                    else if (sportProgramQueryParams.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        ListOfSportsProgram = ListOfSportsProgram.OrderByDescending(p => p.Difficulty);
                }
                else if (sportProgramQueryParams.SortBy.Equals(nameof(SportsProgram.Duration), StringComparison.OrdinalIgnoreCase))
                {

                    if (sportProgramQueryParams.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        ListOfSportsProgram = ListOfSportsProgram.OrderBy(p => p.Duration);
                    else if (sportProgramQueryParams.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        ListOfSportsProgram = ListOfSportsProgram.OrderByDescending(p => p.Duration);

                }
            }

            List<int> BodyfocusCounters = new();
            List<string> bodyfocus = Database.GetListOfBodyFocus().Select(b => b.Value).ToList();
            for (int i = 0; i < bodyfocus.Count; i++)
            {
                BodyfocusCounters.Add(ListOfSportsProgram.Count(ex => ex.BodyFocus!.ToLower().Trim().Contains(bodyfocus[i].ToLower().Trim())));


            }
            List<int> TraningTypeCounters = new();
            List<string> TraningType = Database.GetListOfTrainingType().Select(b => b.Value).ToList();
            for (int i = 0; i < TraningType.Count; i++)
            {
                TraningTypeCounters.Add(ListOfSportsProgram.Count(ex => ex.TrainingType!.ToLower().Trim().Contains(TraningType[i].ToLower().Trim())));

            }
            List<int> DifficultyCounters = new();
            List<string> Difficulty = Database.GetListOfDifficulty().Select(b => b.Value).ToList();
            for (int i = 0; i < Difficulty.Count; i++)
            {
                DifficultyCounters.Add(ListOfSportsProgram.Count(ex => ex.Difficulty.ToString()!.ToLower().Trim() == Difficulty[i].ToLower().Trim()));

            }
            List<int> EquipmentCounters = new();
            List<string> Equipment = Database.GetListOfEquipment().Select(b => b.Value).ToList();
            for (int i = 0; i < Equipment.Count; i++)
            {
                EquipmentCounters.Add(ListOfSportsProgram.Count(ex => ex.Equipment!.ToLower().Trim().Contains(Equipment[i].ToLower().Trim())));

            }
            QueryPageResult<SportsProgram> qpres = CommonMethods.GetPageResult(ListOfSportsProgram, sportProgramQueryParams);
            SportProgramQueryPageResult exqpres = new()
            {
                ListOfData = qpres.ListOfData,
                NextPage = qpres.NextPage,
                TotalCount = qpres.TotalCount,
                TotalPages = qpres.TotalPages,
                PreviousPage = qpres.PreviousPage,
                LastRowOnPage = qpres.LastRowOnPage,
                FirstRowOnPage = qpres.FirstRowOnPage,
                BodyfocusCounters = BodyfocusCounters,
                DifficultyCounters = DifficultyCounters,
                EquipmentCounters = EquipmentCounters,
                TraningTypeCounters = TraningTypeCounters,
                ListOfSelectedFilters = ListOfSelectedFilters
            };
            //if (!string.IsNullOrEmpty(sportProgramQueryParams.SortBy))
            //{
            //    if (sportProgramQueryParams.SortBy.Equals("Fname", StringComparison.OrdinalIgnoreCase))
            //    {
            //        // if (sportProgramQueryParams.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
            //        Trainer = Trainer.OrderByDescending(p => p.Fname);
            //        //else if (sportProgramQueryParams.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
            //        //    Trainer = Trainer.OrderByDescending(p => p.RateId);

            //    }
            //    if (sportProgramQueryParams.SortBy.Equals("Exp_Years", StringComparison.OrdinalIgnoreCase))
            //    {
            //        // if (sportProgramQueryParams.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
            //        Trainer = Trainer.OrderByDescending(p => p.Exp_Years);
            //        //else if (sportProgramQueryParams.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
            //        //    Trainer = Trainer.OrderByDescending(p => p.RateId);

            //    }
            //}
            return exqpres;
        }








    }


}
