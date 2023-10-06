using DAL;
using Logic.Classes;
using Logic.Controllers;

namespace Desktop_application
{
    public partial class ChooseEmployeeByDepartment : Form
    {
        public EmployeeController EmployeeController { get; private set; } = new(new DALEmployeeController());
        public ShiftController ShiftController { get; private set; } = new(new DALShiftController());
        Employee[] _employees;
        Employee _loggedInEmployee;
        List<Employee> _temporaryEmployess = new();
        DateTime _date;
        ShiftType _shiftType;

        public ChooseEmployeeByDepartment(Employee loggedInEmployee, Department department, DateTime date, ShiftType shiftType)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
            _date = date;
            _shiftType = shiftType;
            _employees = EmployeeController.GetAllByDepartment(department);

            foreach (Employee employee in _employees)
            {
                lbxEmployees.Items.Add(employee);
                _temporaryEmployess.Add(employee);
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            lbxEmployees.Items.Clear();
            _temporaryEmployess.Clear();

            foreach (var employee in _employees)
            {
                if (employee.Name.Contains(txbSearch.Text))
                {
                    lbxEmployees.Items.Add(employee);
                    _temporaryEmployess.Add(employee);
                }
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbxEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("The employee was not selected");
                return;
            }
            Employee employee = _temporaryEmployess[lbxEmployees.SelectedIndex];
            Shift shift = new Shift(employee, _date, (int)_shiftType);
            if (ShiftController.AddShift(shift))
                MessageBox.Show("The shift has been created successfully! Please refresh the Shifts Form to see it.");
            else
                MessageBox.Show("Error creating shift");

            this.Close();
        }
    }
}
