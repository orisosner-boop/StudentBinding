using StudentBinding.Models;

namespace StudentBinding
{
    public partial class MainPage : ContentPage
    {
        public Student Student1 { get; set; }
        public Student Student2 { get; set; }
        private Student currentStudent;
        public Student CurrentStudent
        {
            get => currentStudent;
            set
            {
                currentStudent = value;
                OnPropertyChanged(nameof(CurrentStudent));
            }
        }

        public MainPage()
        {
            InitializeComponent();
            Student1 = new Student
            {
                Name = "אורי סוסנר",
                Age = 16,
                BirthDate = new DateTime(2009, 11, 28),
                Image = "daniel.png",
                Email = "ori.sosner@gmail.com",
                Phone = "054-7382910"
            };
            Student2 = new Student
            {
                Name = "נועה לוי",
                Age = 53,
                BirthDate = new DateTime(1973, 1, 2),
                Image = "noa.png",
                Email = "noalevi@gmail.com",
                Phone = "054-5437982"
            };
            CurrentStudent = Student1;
            this.BindingContext = this;
        }
        private void OnChangeStudentClicked(object sender, EventArgs e)
        {
            if (CurrentStudent == Student1)
                CurrentStudent = Student2;
            else
                CurrentStudent = Student1;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
