﻿namespace liaqati_master.Services.Repositories
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
                exercises = exercises.Where(p => p.Title != null && p.Title.ToLower().Contains(exqParameters.SearchTearm.ToLower()) || p.ShortDescription!.ToLower().Contains(exqParameters.SearchTearm.ToLower()));
            }
            if (!string.IsNullOrEmpty(exqParameters.Title))
            {
                exercises = exercises.Where(p => p.Title != null && p.Title.ToLower().Contains(exqParameters.Title.ToLower()) || p.ShortDescription!.ToLower().Contains(exqParameters.SearchTearm.ToLower()));
            }
            if (exqParameters.BodyFocus is not null)
                if (exqParameters.BodyFocus.Count != 0)
                {
                    List<Exercise> ListOfExercises = new();
                    foreach (var item in exqParameters.BodyFocus)
                    {
                        if (item is not null)
                            ListOfExercises.AddRange(exercises.Where(p => p.BodyFocus != null && p.BodyFocus.ToLower().Trim().Contains(item.ToLower().Trim())));
                    }
                    exercises = exercises.AsQueryable();

                }
            if (exqParameters.TraningType is not null)
                if (exqParameters.TraningType.Count != 0)
                {
                    List<Exercise> ListOfExercises = new();
                    foreach (var item in exqParameters.TraningType)
                    {
                        if (item is not null)
                            ListOfExercises.AddRange(exercises.Where(p => p.TraningType != null && p.TraningType.ToLower().Trim().Contains(item.ToLower().Trim())));
                    }
                    exercises = ListOfExercises.AsQueryable();

                }
            if (exqParameters.Difficulty is not null)
                if (exqParameters.Difficulty.Count != 0)
                {
                    List<Exercise> ListOfExercises = new();

                    foreach (var item in exqParameters.Difficulty)
                    {
                        if (item.ToString() is not null)
                            ListOfExercises.AddRange(exercises.Where(p => p.Difficulty != null && p.Difficulty.ToString()!.ToLower().Trim().Contains(item.ToString().ToLower().Trim())));
                    }
                    exercises = ListOfExercises.AsQueryable();

                }

            if (exqParameters.Equipment is not null)

                if (exqParameters.Equipment.Count != 0)
                {
                    List<Exercise> ListOfExercises = new();
                    foreach (var item in exqParameters.Equipment)
                    {
                        if (item is not null)
                            ListOfExercises.AddRange(exercises.Where(p => p.Equipments!.ToLower().Trim().Contains(item.ToLower().Trim())));
                    }

                    exercises = exercises.AsQueryable();
                }


            //if (!string.IsNullOrEmpty(exqParameters.SortBy))
            //{
            //    if (exqParameters.SortBy.Equals("RateId", StringComparison.OrdinalIgnoreCase))
            //    {
            //        // if (exqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
            //        exercises = exercises.OrderByDescending(p => p.RatePercentage);
            //        //else if (exqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
            //        //    exercises = exercises.OrderByDescending(p => p.RateId);

            //    }
            //    if (exqParameters.SortBy.Equals("exerciseDate", StringComparison.OrdinalIgnoreCase))
            //    {
            //        // if (exqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
            //        exercises = exercises.OrderByDescending(p => p.exerciseDate);
            //        //else if (exqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
            //        //    exercises = exercises.OrderByDescending(p => p.RateId);

            //    }
            //}
            if (!string.IsNullOrEmpty(exqParameters.SortBy))
            {
                if (exqParameters.SortBy.Equals(nameof(Exercise.Title), StringComparison.OrdinalIgnoreCase))
                {
                    if (exqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        exercises = exercises.OrderBy(p => p.Title);
                    else if (exqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        exercises = exercises.OrderByDescending(p => p.Title);

                }
                else if (exqParameters.SortBy.Equals(nameof(Exercise.Price), StringComparison.OrdinalIgnoreCase))
                {
                    if (exqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        exercises = exercises.OrderBy(p => p.Price);
                    else if (exqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        exercises = exercises.OrderByDescending(p => p.Price);

                }
                else if (exqParameters.SortBy.Equals(nameof(Exercise.Difficulty), StringComparison.OrdinalIgnoreCase))
                {
                    if (exqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        exercises = exercises.OrderBy(p => p.Difficulty);
                    else if (exqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        exercises = exercises.OrderByDescending(p => p.Difficulty);
                }
                else if (exqParameters.SortBy.Equals(nameof(Exercise.Duration), StringComparison.OrdinalIgnoreCase))
                {

                    if (exqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        exercises = exercises.OrderBy(p => p.Duration);
                    else if (exqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        exercises = exercises.OrderByDescending(p => p.Duration);

                }
                else if (exqParameters.SortBy.Equals(nameof(Exercise.RatePercentage), StringComparison.OrdinalIgnoreCase))
                {

                    if (exqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        exercises = exercises.OrderBy(p => p.Duration);
                    else if (exqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        exercises = exercises.OrderByDescending(p => p.Duration);

                }
                else if (exqParameters.SortBy.Equals(nameof(Exercise.exerciseDate), StringComparison.OrdinalIgnoreCase))
                {

                    if (exqParameters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        exercises = exercises.OrderBy(p => p.Duration);
                    else if (exqParameters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        exercises = exercises.OrderByDescending(p => p.Duration);

                }
            }
            List<int> BodyfocusCounters = new();
            List<string> bodyfocus = Database.GetListOfBodyFocus().Select(b => b.Value).ToList();
            foreach (var item in bodyfocus)
            {
                BodyfocusCounters.Add(exercises.Count(ex => ex.BodyFocus!.ToLower().Trim().Contains(item.ToLower().Trim())));
            }
            List<int> TraningTypeCounters = new();
            List<string> TraningType = Database.GetListOfTrainingType().Select(b => b.Value).ToList();
            foreach (var item in TraningType)
            {
                TraningTypeCounters.Add(exercises.Count(ex => ex.TraningType!.ToLower().Trim().Contains(item.ToLower().Trim())));

            }
            List<int> DifficultyCounters = new();
            List<string> Difficulty = Database.GetListOfDifficulty().Select(b => b.Value).ToList();
            foreach (var item in Difficulty)
            {
                DifficultyCounters.Add(exercises.Count(ex => ex.Difficulty.ToString()!.ToLower().Trim() == item.ToLower().Trim()));
            }
            List<int> EquipmentCounters = new();
            List<string> Equipment = Database.GetListOfEquipment().Select(b => b.Value).ToList();
            foreach (var item in Equipment)
            {
                EquipmentCounters.Add(exercises.Count(ex => ex.Equipments!.ToLower().Trim().Contains(item.ToLower().Trim())));
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
