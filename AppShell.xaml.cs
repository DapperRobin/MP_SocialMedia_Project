using CommunityToolkit.Maui.Extensions;
using SMP_MP.PopUps;
using System.Windows.Input;

namespace SMP_MP
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
