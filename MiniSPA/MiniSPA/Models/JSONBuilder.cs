using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniSPA.Models
{
    public class JSONBuilder
    {
        public RegistrationVm BuildRegistrationVm()
        {
            var registrationVm = new RegistrationVm
            {
                Trainings = GetSerializedTraining(),
                Trainers = GetSerializedTrainers()
            };

            return registrationVm;
        }

        public string GetSerializedTraining()
        {
            var trainings = new[]
                {
                    new TrainingVm {TrainingCode = "TRA001", Title = "ASP.NET MVC 4", Trainer="Mahedee Hasan"},
                    new TrainingVm {TrainingCode = "TRA002", Title = "ASP.NET Web Form", Trainer="Asrafuzzaman"},
                    new TrainingVm {TrainingCode = "TRA003", Title = "AngularJs Fundamental", Trainer="Foysal Alam"},
                    new TrainingVm {TrainingCode = "TRA004", Title = "ASP.NET MVC 5 with web API", Trainer="Asfaquzzaman"},
                };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var serializeCourses = JsonConvert.SerializeObject(trainings, Formatting.None, settings);
            return serializeCourses;
        }


        public string GetSerializedTrainers()
        {
            var trainers = new[]
                {
                    new TrainerVm {Name = "Mahedee Hasan", Email = "mahedee.hasan@gmail.com", Venue="Leadsoft Bangladesh Ltd"},
                    new TrainerVm {Name = "Asrafuzzaman", Email = "asraf@gmail.com", Venue="Leadsoft Bangladesh Ltd"},
                    new TrainerVm {Name = "Foysal Alam", Email = "foysal@gmail.com", Venue="Leadsoft Bangladesh Ltd"},
                    new TrainerVm {Name = "Asfaquzzaman", Email = "asfaq@gmail.com", Venue="Leadsoft Bangladesh Ltd"},
                };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var serializedInstructors = JsonConvert.SerializeObject(trainers, Formatting.None, settings);
            return serializedInstructors;
        }
    }
}