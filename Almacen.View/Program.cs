using System;
using Spring.Windows;
namespace Almacen.View
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            log4net.Config.XmlConfigurator.Configure();
            const string startup = "assembly://Almacen.View/Almacen.View.Config/Startup.xml";
            const string dao = "assembly://Almacen.Data/Almacen.Data.Dao/Dao.xml";
            const string service = "assembly://Almacen.Business/Almacen.Business/Services.xml";
            const string view = "assembly://Almacen.View/Almacen.View.Config/View.xml";

            Application.Initialize(startup, dao, service, view);
            Application.Run(new FrmAcceso());
        }
    }
}
