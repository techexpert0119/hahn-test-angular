using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IReportService
    {
        public void CreateReport(ReportAggregate report);
        public bool UpdateReport(ReportAggregate report);
        public bool DeleteReport(int id);
        public bool ChangeOrder(int id);
        public bool DeleteOne(int id);
        public ReportAggregate GetReport(int id);
        public IEnumerable<ReportAggregate> GetAllReports();
    }
}
