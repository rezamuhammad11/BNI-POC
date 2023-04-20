using BNI_POC.API.Models;
using BNI_POC.API.ViewModels;
using BNI_POC.ViewModels;

namespace BNI_POC.API.Provider
{
    public interface ITrainingLogProvider
    {
        ProcessResult Save(TrainingLogViewModel model);
    }
    public class TrainingLogProvider : ITrainingLogProvider
    {

        BNI_POCContext _context;

        public TrainingLogProvider(BNI_POCContext context)
        {
            _context = context;
        }
        
        public ProcessResult Save(TrainingLogViewModel model)
        {

            ProcessResult result = new ProcessResult();
            try
            {
                var dt = new TrainingLog();
                dt.Customername = model.CustomerName;
                dt.Identityno = model.IdentityNo;
                dt.Logdate = DateTime.Now;

                _context.TrainingLogs.Add(dt);
                _context.SaveChanges();                   

                result.InsertSucceed();
            }
            catch (Exception ex)
            {
                result.message = ex.Message;
                result.isSucceed = false;
            }
            return result;
        }
    }    
}
