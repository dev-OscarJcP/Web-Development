using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;

namespace DevFreela.Application.ViewModels
{
    public class ProjectDetailViewModel
    {
        public ProjectDetailViewModel(int id, string title, string description, int idClient, decimal totalCost, DateTime? startedAt, DateTime? finishedAt)
        {
            Id = id;
            Title = title;
            Description = description;
            IdClient = idClient;
            TotalCost = totalCost;
            StartedAt = startedAt;
            FinishedAt = finishedAt;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get;private set; }
        public int IdClient { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
    }
}
