using Demo.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Demo.ViewModels
{
    public class PersonasViewModel : ViewModelBase
    {
        #region Propiedades

        private string _Resultado;
        public string Resultado
        {
            get { return _Resultado; }
            set
            {
                _Resultado = value;
                OnPropertyChanged(nameof(Resultado));
            }
        }





        private string _Nombres;
        public string Nombres
        {
            get { return _Nombres; }
            set
            {
                _Nombres = value;
                OnPropertyChanged(nameof(Nombres));
            }
        }

        private string _Apellidos;
        public string Apellidos
        {
            get { return _Apellidos; }
            set
            {
                _Apellidos = value;
                OnPropertyChanged(nameof(Apellidos));
            }
        }

        private string _Edad;
        public string Edad
        {
            get { return _Edad; }
            set
            {
                _Edad = value;
                OnPropertyChanged(nameof(Edad));
            }
        }


        #endregion


        #region Comando
        public ICommand GuardarCommand { get; }

        public PersonasViewModel()
        {
            GuardarCommand = new RelayCommand(Guardar);
        }
        private void Guardar()
        {
            Resultado = string.Concat(Nombres, " ", Apellidos, " ", Edad);

        }
        #endregion

    }
}
