
// Declaração de Variáveis
            int cod_vend,
            // Número de identificação do vendedor 
            car_vend;
            // Número de carros vendidos pelo vendedor 
            double sal_fixo,
            // Salário Fixo do vendedor
            percent, 
            // Percentual sobre o total das vendas do vendedor 
            total_vend,
            // Total das vendas com carros do vendedor 
            val_pcar,
            // Valor de comissão a ser ganha por carro vendido 
            sal_mensal;
            // Salário Mensal do Vendedor 
            // Inicialização de Variáveis 
            percent = 0.05; // Cinco por cento 
            // Solicita e lê as informações do vendedor 

            Console.Write("Informe a matrícula do vendedor: ");
            cod_vend = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            // Solicita e lê o valor do salário fixo do vendedor 
            Console.Write("Entre com o valor do salário fixo do vendedor: ");
            sal_fixo = Double.Parse(Console.ReadLine());

            Console.WriteLine();
            // Solicita e lê a quantidade de carros vendidos pelo vendedor 
            Console.Write("Entre com o número de carros vendidos pelo vendedor: ");
            car_vend = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            // Solicita e lê o valor ganho por carro vendido 
            Console.Write("Entre com o valor de comissão a ser ganho por carro vendido pelo vendedor: ");
            val_pcar = Double.Parse(Console.ReadLine());

            Console.WriteLine();
            // Solicita e lê o valor total das vendas do vendedor 
            Console.Write("Entre com o valor das vendas do vendedor: ");
            total_vend = Double.Parse(Console.ReadLine());

            // Efetua o cálculo do salário total do vendedor 
            sal_mensal = sal_fixo + (val_pcar * car_vend) + (total_vend * percent);
          
            // Exibe o valor do Salário Total do Vendedor 

            Console.WriteLine(String.Format("O Vendedor {0} tem salário total de: {1}", cod_vend, sal_mensal));
            Console.ReadLine();  