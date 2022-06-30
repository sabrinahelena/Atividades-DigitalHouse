using Caliburn.Micro;
using Caliburn.Micro;
using System.Windows;
using Aula17_WPF.ViewModels;



namespace Aula17_WPF
{
    public class Bootstrapper : BootstrapperBase
    {
            public Bootstrapper()
            {
                Initialize();
            }

            protected override void OnStartup(object sender, StartupEventArgs e)
            {
                DisplayRootViewForAsync<ShellViewModel>();
            }
    }
}
