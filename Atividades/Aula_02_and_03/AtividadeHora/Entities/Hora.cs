using System;

namespace AtividadeHora.Entities
{
    public class Hora
    {
        private int _hora;
        private int _minutos;
        private int _segundos;

        public Hora(int horas, int minutos, int segundos)
        {
            setSegundos(segundos);
            setMinutos(minutos);
            setHora(horas);  
        }

        public int getHora() {
            return this._hora;
        }

        public void setHora(int horas) {
            this._hora += horas;
        }

        public int getMinutos() {
            return this._minutos;
        }
        public void setMinutos(int minutos) {
            do {
                if(minutos >= 60) {
                    setHora(1);
                    minutos -= 60;
                } else {
                    this._minutos += minutos;
                    minutos -= minutos;
                }
            } while(minutos != 0);
        }

        public int getSegundos() {
            return this._segundos;
        }

        public void setSegundos(int segundos) {
            do{
                if(segundos >= 60) {
                    setMinutos(1);
                    segundos -= 60;
                } else {
                    this._segundos = segundos;
                   segundos -= segundos;
                }
            }while(segundos != 0);
        }

    }
}