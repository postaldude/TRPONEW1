using System.Collections.Generic;
using TRPO.Core.ProjectAggregate;

namespace TRPO.Web.Endpoints.ProjectEndpoints
{
    public class ProjectListResponse
    {
        public List<ProjectRecord> Projects { get; set; } = new();
    }
}
