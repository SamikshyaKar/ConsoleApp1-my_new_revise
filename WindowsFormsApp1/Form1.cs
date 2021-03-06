using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            //string TypeName= txtTypeName.Text;
            // Type T = Type.GetType(TypeName);
            // //lstMethods.Items.Clear();
            // MethodInfo[] methods = T.GetMethods();
            // foreach (MethodInfo method in methods)
            // {
            //     lstMethods.Items.Add(method.Name);
            // }

            string TypeName = txtTypeName.Text;
            Type T = Type.GetType(TypeName);
            lstMethods.Items.Clear();
           
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                lstMethods.Items.Add(method.ReturnType.Name + " " + method.Name);
            }

        }

        private void txtTypeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstMethods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


//string TypeName = txtTypeName.Text;
//Type T = Type.GetType(TypeName);
//lstMethods.Items.Clear();
//lstProperties.Items.Clear();
//lstConstructors.Items.Clear();
//MethodInfo[] methods = T.GetMethods();
//foreach (MethodInfo method in methods)
//{
//    lstMethods.Items.Add(method.ReturnType.Name + " " + method.Name);
//}
//PropertyInfo[] properties = T.GetProperties();
//foreach (PropertyInfo property in properties)
//{
//    lstProperties.Items.Add(property.PropertyType.Name + " " + property.Name);
//}
//ConstructorInfo[] constructors = T.GetConstructors();
//foreach (ConstructorInfo constructor in constructors)
//{
//    lstConstructors.Items.Add(constructor.ToString());
//}


