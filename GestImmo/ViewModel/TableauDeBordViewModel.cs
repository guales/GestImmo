using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GestImmo.ViewModel
{
    class TableauDeBordViewModel : ViewModelBase
    {
        #region Fields

        /// <summary>
        /// Action du clic sur le bouton Save
        /// </summary>
        private ICommand _saveCommand;

        /// <summary>
        /// Action du clic sur le bouton Edit
        /// </summary>
        private ICommand _editCommand;

        /// <summary>
        /// True si mode modification, false sinon (mode consulation)
        /// </summary>
        private bool _isEditing;

        #endregion // Fields


        #region Constructors

        /// <summary>
        /// Constructeur de TableauDeBordViewModel. Initialise _isEditing à false.
        /// </summary>
        public TableauDeBordViewModel()
        {
            _isEditing = false;
        }

        #endregion // Constructors


        #region Properties

        /// <summary>
        /// Retourne la valeur de _isEditing
        /// Modifie la valeur de _isEditing et envoie l'event OnPropertyChanged
        /// </summary>
        public bool IsEditing
        {
            get { return _isEditing; }

            set
            {
                if (_isEditing == value)
                {
                    return;
                }

                _isEditing = value;
                OnPropertyChanged("IsEditing");
            }
        }

        #endregion // Properties


        #region Commands Properties

        /// <summary>
        /// Commande correspondant au bouton Save
        /// </summary>
        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new RelayCommand(
                        param => this.Save(),
                        param => this.CanSave()
                    );
                }
                return _saveCommand;
            }
        }

        /// <summary>
        /// Commande correspondant au bouton Edit
        /// </summary>
        public ICommand EditCommand
        {
            get
            {
                if (_editCommand == null)
                {
                    _editCommand = new RelayCommand(
                        param => this.Edit(),
                        param => this.CanEdit()
                    );
                }
                return _editCommand;
            }
        }

        #endregion // Commands Properties


        #region Commands

        /// <summary>
        /// On peut savegarder ssi mode modification.
        /// </summary>
        /// <returns>IsEditing</returns>
        public bool CanSave()
        {
            return IsEditing;
        }

        /// <summary>
        /// On peut savegarder ssi mode consultation.
        /// </summary>
        /// <returns>!IsEditing</returns>
        public bool CanEdit()
        {
            return !IsEditing;
        }

        /// <summary>
        /// Change le mode de modification à consultation.
        /// TODO : modifier les champs en base
        /// </summary>
        private void Save()
        {
            IsEditing = !IsEditing;
        }

        /// <summary>
        /// Change le mode de consultation à modification.
        /// </summary>
        private void Edit()
        {
            IsEditing = !IsEditing;
        }

        #endregion // Commands
    }
}
