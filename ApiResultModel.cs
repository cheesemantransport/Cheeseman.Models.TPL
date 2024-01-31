namespace Cheeseman.Models.TPL
{
    public class ApiResultModel<T>
    {
        public string[] Errors { get; set; }

        public T Result { get; set; }
    }
}
