using System;
namespace AtividadeData.Entities
{
    public class Data
    {
        private int day;
        private int month;
        private int year;

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
            Console.WriteLine(data + " é um " + type + " inválido!");
        }
    }
}