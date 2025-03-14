using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary.Views;
using Veterinary.Models;
using Veterinary._Repositories;
using System.Windows.Forms;

namespace Veterinary.Presenters
{
    public class MainPresenter
    {
        private IMainView _view;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView view, string sqlConnectionString)
        {
            _view = view;
            this.sqlConnectionString = sqlConnectionString;
            this._view.ShowPetView += ShowPetView;
        }

        private void ShowPetView(object? sender, EventArgs e)
        {
            IPetView view = PetView.GetInstance((Form)_view);
            IPetRepository repository = new PetRepository(sqlConnectionString);
            new PetPresenter(view, repository);
        }
    }
}
