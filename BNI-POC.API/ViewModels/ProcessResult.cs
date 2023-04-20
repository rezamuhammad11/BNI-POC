namespace BNI_POC.ViewModels
{
    public class ProcessResult
    {
        public System.Collections.Generic.Dictionary<string, object> CustomField
        {
            get;
            set;
        }

        public string value
        {
            get;
            set;
        }

        public bool isSucceed
        {
            get;
            set;
        }

        public string message
        {
            get;
            set;
        }

        public ProcessResult()
        {
            this.isSucceed = false;
            this.message = "";
            this.CustomField = new System.Collections.Generic.Dictionary<string, object>();
        }

        public void ApproveSucceed()
        {
            this.isSucceed = true;
            this.message = "Approve Succeed.";
        }

        public void InsertSucceed()
        {
            this.isSucceed = true;
            this.message = "Data has been saved.";
        }

        public void UpdateSucceed()
        {
            this.isSucceed = true;
            this.message = "Data has been saved.";
        }

        public void UploadSucceed()
        {
            this.isSucceed = true;
            this.message = "Upload process is running in the background process.";
        }

        public void DeleteSucceed()
        {
            this.isSucceed = true;
            this.message = "Data has been deleted.";
        }
        public void DataIsExist(string id)
        {
            this.isSucceed = true;
            this.message = id + " already exist";
        }

        public void ProcessSucceed(string message)
        {
            this.isSucceed = true;
            this.message = message;
        }

        public void ProcessFailed(string message)
        {
            this.isSucceed = false;
            this.message = message;
        }
    }
}
