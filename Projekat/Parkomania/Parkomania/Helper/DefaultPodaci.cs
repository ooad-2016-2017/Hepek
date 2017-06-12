using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace Parkomania.Helper
{
    class DefaultPodaci
    {
        public static void Initialize(dbContext.Parking context)
        {
            if (!context.location.Any())
            {
                context.location.AddRange(
                new Model.Location()
                {
                    x = 43.856f,
                    y = 18.39f
                }
                );
                context.SaveChanges();
            }
            if (!context.account.Any())
            {
                context.account.AddRange(
                new Model.Account("Niko","Nikic","test@test.com","202cb962ac59075b964b07152d234b70","parking"),
                new Model.Account("Nikolija", "Nikolic", "nikolija@test.com", "202cb962ac59075b964b07152d234b70", "user"),
                new Model.Account("Himzo", "Polovina", "hpolovina1@test.com", "202cb962ac59075b964b07152d234b70", "admin"));
                context.SaveChanges();
            }
            /*if (!context.pmodels.Any())
            {
                context.pmodels.AddRange(
                new Model.ParkingModel(6));
                context.SaveChanges();
            }*/
            if (!context.parking.Any())
            {
                context.parking.AddRange(
                new Model.Parking(1,"Test","Sarajevo","Bosna i Hercegovina",1,1f,7,20,6,6,1,1));
                IMobileServiceTable<AzureTabela.Parking> userTableObj = App.MobileService.GetTable<AzureTabela.Parking>();
                AzureTabela.Parking p = new AzureTabela.Parking(1, "Test", "Sarajevo", "Bosna i Hercegovina", 1, 1f, 7, 20, 6, 6, 1, 1);
                try
                {
                    userTableObj.InsertAsync(p);
                    MessageDialog msgDialog = new MessageDialog("Uspješno.");                    msgDialog.ShowAsync();
                }
                catch (Exception ex)
                {
                    MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                    msgDialogError.ShowAsync();
                }

                context.SaveChanges();
            }
            if (!context.pmanager.Any())
            {
                context.pmanager.AddRange(
                new Model.ParkingManager(0));
                context.SaveChanges();
            }
            if (!context.account.Any())
            {
                context.account.AddRange(
                new Model.Account("Nikolija", "Nikolic", "nikolija@test.com", "202cb962ac59075b964b07152d234b70", "user"));
                context.SaveChanges();
            }
            if (!context.account.Any())
            {
                context.account.AddRange(
                new Model.Account("Himzo", "Polovina", "hpolovina1@test.com", "202cb962ac59075b964b07152d234b70", "admin"));
                context.SaveChanges();
            }
            if (!context.user.Any())
            {
                Model.User u = new Model.User();
                u.locationid = 1;
                u.accid = 2;
                context.user.AddRange(
                    u
                );
                context.SaveChanges();
            }

        }
    }
}
