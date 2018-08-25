namespace Pharmacy.Common
{
    public class ViewModelWithPages
    {
        public int CurrentPage { get; set; }

        public int PreviousePage => this.CurrentPage - 1;

        public int NextPage => this.CurrentPage + 1;

        public int AllPages { get; set; }
    }
}
