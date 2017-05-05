namespace TC.Vacations.Entity.DsfInterface
{
    public class InterfacecResponse
    {
        /// <summary>
        /// 消息
        /// </summary>
        public string Message { set; get; }

        /// <summary>
        /// 状态 
        /// </summary>
        public int Status { set; get; }
    }

    public enum QueryStatusCode
    {
        Error = 0,
        NoExist = 1,
        Exist = 2
    }
}
