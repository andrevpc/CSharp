// Despesas Andre = new Despesas(09673557969);
// Andre.ListaDespesas.Add(new DespesaMes(9, 1500.5f));
// Andre.ListaDespesas.Add(new DespesaDia(10, 9, 1200.4f));
// Andre.ListaDespesas.Add(new DespesaMes(10, 1500.5f));
// Andre.totalixaMes(9);
// public class DespesaMes
// {
//     private int mes { get; set; }
//     private float valor { get; set; }
// public DespesaMes(int mes, float valor)
// {
//     this.mes = mes;
//     this.valor = valor;
// }
// public int getMes()
// {
//     return mes;
// }
// public float getValor()
// {
//     return valor;
// } 
// } 
// public class DespesaDia : DespesaMes
// {
// private int dia;
// public DespesaDia(int dia, int mes, float valor) : base(mes, valor)
// {
//     this.dia = dia;
// }
// public int getDia()
// {
//     return dia;
// }
// }

// public class Despesas
// {
//     public List<DespesaMes> ListaDespesas { get; set; }
//     public double CPF { get; set; }
//     public Despesas(double cpf)
//     {
//         this.CPF = cpf;
//         this.ListaDespesas = new List<DespesaMes>();
//     }
//     public double getCPF() => this.CPF;
//     public DespesaMes totalixaMes(int mes)
//     {
//         float valor = 0;
//         foreach (DespesaMes i in ListaDespesas)
//         {
//             if(i.getMes() == mes)
//             {
//                 valor += i.getValor();
//             }
//         }
//         Console.WriteLine(valor);
//         return new DespesaMes(mes, valor);
//     }
// }