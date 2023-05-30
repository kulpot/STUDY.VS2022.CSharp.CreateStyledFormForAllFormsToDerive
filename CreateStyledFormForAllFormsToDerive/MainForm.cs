using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ref link:https://www.youtube.com/watch?v=MmRr1Jka42o&list=PLAIBPfq19p2EJ6JY0f5DyQfybwBGVglcR&index=77
//Saves time in a themed application. You can also use this for other things that can be consistent in your forms.

namespace CreateStyledFormForAllFormsToDerive
{
    public partial class MainForm : StyledForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
