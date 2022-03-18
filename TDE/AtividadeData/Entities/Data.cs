using System;
namespace AtividadeData.Entities
{
    public class Data
    {
        private int day;
        private int month;
        private int year;

        public Data(int year, int month, int day) {
            setYear(year);
            setMonth(month);
            setDay(day);
            imprimirData();
        }
        public int getDay() {return this.day;}
        public void setDay(int day) {

            if (day <= 0) {
                MessageErro(day, "dia");
            } if(getMonth() == 2 && day > 28) {
                MessageErro(day, "dia");
            } else {
                this.day = day;
            }
        }
        public int getMonth() {return this.month;}
        public void setMonth(int month) {
            if(month > 0 && month <= 12) {
                this.month = month;
            } else {
                MessageErro(month, "mês");
            }
        }
        public int getYear() {return this.year;}
        public void setYear(int year) {
                 if(year > 0) {
                    this.year = year;
                } else {
                    MessageErro(year, "ano");
                }  
        }
        private void MessageErro(int data, String type) {
            Console.WriteLine(Convert.ToString(data + " é um " + type + " inválido!"));
        }

        private void imprimirData() {
            try {
                if (getDay() != 0 && getMonth() != 0 && getYear() != 0) {
                    Console.WriteLine(getDay() + "/" + getMonth() + "/" + getYear());
                }
            } catch (ArgumentException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}

    //throw new ArgumentException(paramName: nameof(this.year), message: "teste");