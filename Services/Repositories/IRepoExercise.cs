namespace liaqati_master.Services.Repositories
{
    public class IRepoExercise
    {
        private readonly LiaqatiDBContext _context;

        public IRepoExercise(LiaqatiDBContext context)
        {
            _context = context;
        }

        public async Task<Exercise> AddEntityAsync(Exercise Entity)
        {
            await _context.TblExercises.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<Exercise> DeleteEntityAsync(Exercise Entity)
        {
            if (Entity != null)
            {
                _context.TblExercises.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new Exercise();
            }
        }

        public async Task<Exercise> DeleteEntityAsync(string Id)
        {
            var article = await _context.TblExercises.FindAsync(Id);
            if (article != null)
            {
                _context.TblExercises.Remove(article);
                await SaveAsync();
                return article;
            }
            else
            {
                return new Exercise();
            }
        }

        public async Task<IEnumerable<Exercise>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblExercises.ToListAsync();
        }

        public async Task<Exercise?> GetByIDAsync(string EntityId)
        {
            return await _context.TblExercises.FirstOrDefaultAsync(a => a.Id == EntityId);
        }

        public async Task SaveAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Exercise> UpdateEntityAsync(Exercise Entity)
        {
            Exercise? article = await _context.TblExercises.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (article != null)
            {
                _context.TblExercises.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new Exercise();
            }
        }
        public async Task<ExerciseQueryPageResult> SearchExercies(ExerciseQueryParamters exqParameters)
        {
            IQueryable<Exercise> exercises = (await GetAllAsync()).AsQueryable();
            List<Exercise> ex;



            if (exqParameters.MinDuration != null)
            {
                exercises = exercises.Where(p => p.Duration >= exqParameters.MinDuration);
            }

            if (exqParameters.MaxDuration != null)
            {
                exercises = exercises.Where(p => p.Duration <= exqParameters.MaxDuration);


            }
            if (!string.IsNullOrEmpty(exqParameters.SearchTearm))
            {
                exercises = exercises.Where(p =>
                    p.Title.ToLower().Contains(exqParameters.SearchTearm.ToLower()) ||
                    p.ShortDescription.ToLower().Contains(exqParameters.SearchTearm.ToLower())
                );
            }
            if (exqParameters.BodyFocus is not null)

                if (exqParameters.BodyFocus.Count != 0)
                {
                    exercises = exercises.Where(p => exqParameters.BodyFocus.Contains(p.BodyFocus.ToLower()));


                }
            if (exqParameters.TraningType is not null)

                if (exqParameters.TraningType.Count != 0)
                {
                    exercises = exercises.Where(p => exqParameters.TraningType.Contains(p.TraningType.ToLower()));
                }
            if (exqParameters.Difficulty is not null)

                if (exqParameters.Difficulty.Count != 0)
                {
                    exercises = exercises.Where(p => exqParameters.Difficulty.Contains(p.Difficulty.Value));
                }
            if (exqParameters.Equipment is not null)

                if (exqParameters.Equipment.Count != 0)
                {
                    List<Exercise> Exercises = new List<Exercise>();
                    for (int i = 0; i < exqParameters.Equipment.Count; i++)
                    {

                        Exercises.AddRange(exercises.Where(p => p.Equipments.Contains(exqParameters.Equipment[i])));
                    }

                    exercises = Exercises.AsQueryable();
                }

            if (!string.IsNullOrEmpty(exqParameters.SortBy))
            {
                if (exqParameters.SortBy.Equals("RateId", StringComparison.OrdinalIgnoreCase))
                {
                    // if (exqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                    exercises = exercises.OrderByDescending(p => p.RatePercentage);
                    //else if (exqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                    //    exercises = exercises.OrderByDescending(p => p.RateId);

                }
                if (exqParameters.SortBy.Equals("exerciseDate", StringComparison.OrdinalIgnoreCase))
                {
                    // if (exqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                    exercises = exercises.OrderByDescending(p => p.exerciseDate);
                    //else if (exqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                    //    exercises = exercises.OrderByDescending(p => p.RateId);

                }
            }

            List<int> BodyfocusCounters = new();
            List<string> bodyfocus = Database.GetListOfBodyFocus().Select(b => b.Value).ToList();
            for (int i = 0; i < bodyfocus.Count; i++)
            {
                BodyfocusCounters.Add(exercises.Count(ex => ex.BodyFocus.Contains(bodyfocus[i])));

            }
            List<int> TraningTypeCounters = new();
            List<string> TraningType = Database.GetListOfTrainingType().Select(b => b.Value).ToList();
            for (int i = 0; i < TraningType.Count; i++)
            {
                TraningTypeCounters.Add(exercises.Count(ex => ex.TraningType.Contains(TraningType[i])));

            }
            List<int> DifficultyCounters = new();
            List<string> Difficulty = Database.GetListOfDifficulty().Select(b => b.Value).ToList();
            for (int i = 0; i < Difficulty.Count; i++)
            {
                DifficultyCounters.Add(exercises.Count(ex => ex.Difficulty.ToString() == Difficulty[i]));

            }
            List<int> EquipmentCounters = new();
            List<string> Equipment = Database.GetListOfEquipment().Select(b => b.Value).ToList();
            for (int i = 0; i < Equipment.Count; i++)
            {
                EquipmentCounters.Add(exercises.Count(ex => ex.Equipments.Contains(Equipment[i])));

            }
            QueryPageResult<Exercise> qpres = CommonMethods.GetPageResult(exercises, exqParameters);
            ExerciseQueryPageResult exqpres = new()
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
                TraningTypeCounters = TraningTypeCounters


            };




            return exqpres;
        }


    }
}
