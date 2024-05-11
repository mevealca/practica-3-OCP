# practica-3-OCP
En este repositorio estaremos implementando el principio de open/close  OCP

Como tarea debemos refactorizar el siguiente escenario:


             public decimal Calculate(decimal income, decimal deduction,string country)
             {
             decimal taxAmount = 0;
             decimal taxableIncome = income - deduction;
             switch(country)
             {
             case "India":
             //calculation here
             break;
             case "USA":
             //calculation here
             break;
             case "UK":
             //calculation here
             break;
             }
             return taxAmount;
             } 

Para refactorizar esta clase y permitir que se cumpla el principio solicitado los pasos que realice fueron:

1) Crear una interface que será la encargada de tener el método calculate y recibir las propiedades (income y deduction) que son necesarias y obligatorias para poder determinar los cálculos
2) Crear una clase para cada país la cual heredaran de la interfaz de forma que podamos implementar tanto las propiedades requeridas como el método encargado de realizar los cálculos según las estipulaciones de ese país
3) Cree una clase typo Enum que permite de una forma más dinámica establecer valores para identificar los países a la hora de determinar que norma según el país debo implementar la cual es utilizada en la clase program que es una app de consola para prueba
4) Refactorizamos la clase taxcalculator para que implemente la inversión de dependencia a través del método Calculate donde estaremos recibiendo la interface ICalculate que fue creada en el punto 1 y en la cual podremos realizar el uso de los distintos cálculos que necesitemos
5) En la clase program podremos ver cómo podemos aplicar el funcionamiento de lo implementado
