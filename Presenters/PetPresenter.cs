using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary.Models;
using Veterinary.Views;

namespace Veterinary.Presenters
{
    public class PetPresenter
    {
        private IPetView _view;
        private IPetRepository _repository;
        private BindingSource _petListBindingSource;
        private IEnumerable<PetModel> _petList;

        public PetPresenter(IPetView view, IPetRepository repository)
        {
            this._view = view;
            this._repository = repository;
            this._petListBindingSource = new BindingSource();
            
            //Subscribe event handler methods to view events
            this._view.SearchEvent += SearchPet;
            this._view.AddNewEvent += AddNewPet;
            this._view.EditEvent += LoadSelectedPetToEdit;
            this._view.DeleteEvent += DeleteSelectedPet;
            this._view.SaveEvent += SavePet;
            this._view.CancelEvent += CancelAction;
            // Set pets binding source
            this._view.SetPetListBindingSource(_petListBindingSource);
            //load pet list view
            LoadAllPetList();
            //Show view
            this._view.Show();
        }

        private void LoadAllPetList()
        {
            _petList = _repository.GetAll();
            _petListBindingSource.DataSource = _petList; // set data source
        }

        private void SearchPet(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this._view.SearchValue);

            if (!emptyValue)
            {
                _petList = _repository.GetByValue(this._view.SearchValue);
            } else
            {
                _petList = _repository.GetAll();
            }
            _petListBindingSource.DataSource = _petList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePet(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedPet(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedPetToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPet(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


    }
}
