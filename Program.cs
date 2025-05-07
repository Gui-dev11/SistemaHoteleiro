using static System.Console;

namespace SistemaHoteleiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            Cliente cliente = new Cliente();
            Funcionario funcionario = new Funcionario();
            Quarto quarto = new Quarto();
            Servicos servico = new Servicos();
            Reserva reserva = new Reserva();
            Endereco endereco = new Endereco();

            //hotel
            WriteLine("Cadastro do Hotel");
            WriteLine();

            Write("Nome do hotel: ");
            hotel.setNomeCompleto(ReadLine());

            Write("Nome da empresa: ");
            hotel.setNomeEmpresa(ReadLine());

            Write("Data de fundação: ");
            hotel.setDataFundacao(ReadLine());

            Write("E-mail corporativo: ");
            hotel.setEmailCorporativo(ReadLine());

            WriteLine("\nEndereço do hotel:");
            Write("Estado: ");
            endereco.setEstado(ReadLine());
            Write("Cidade: ");
            endereco.setCidade(ReadLine());
            Write("Bairro: ");
            endereco.setBairro(ReadLine());
            Write("CEP: ");
            endereco.setCep(ReadLine());
            Write("Logradouro: ");
            endereco.setLogradouro(ReadLine());
            Write("Complemento: ");
            endereco.setComplemento(ReadLine());
            Write("Número: ");
            endereco.setNumero(ReadLine());

            hotel.setEndereco(endereco);

            //cliente
            Clear();
            WriteLine("Cadastro do Cliente");
            WriteLine();

            Write("Nome: ");
            cliente.setNome(ReadLine());

            Write("Código: ");
            cliente.setCodigo(ReadLine());

            Write("Profissão: ");
            cliente.setProfissao(ReadLine());

            Write("RG: ");
            cliente.setRg(ReadLine());

            Write("CPF: ");
            cliente.setCpf(ReadLine());

            WriteLine("\nEndereço do cliente:");
            Write("Estado: ");
            endereco.setEstado(ReadLine());
            Write("Cidade: ");
            endereco.setCidade(ReadLine());
            Write("Bairro: ");
            endereco.setBairro(ReadLine());
            Write("CEP: ");
            endereco.setCep(ReadLine());
            Write("Logradouro: ");
            endereco.setLogradouro(ReadLine());
            Write("Complemento: ");
            endereco.setComplemento(ReadLine());
            Write("Número: ");
            endereco.setNumero(ReadLine());

            cliente.setEndereco(endereco);

            //funcionario
            Clear();
            WriteLine("Cadastro do Funcionário");
            WriteLine();

            Write("Nome: ");
            funcionario.setNome(ReadLine());

            Write("Código: ");
            funcionario.setCodigo(ReadLine());

            Write("RG: ");
            funcionario.setRg(ReadLine());

            Write("CPF: ");
            funcionario.setCpf(ReadLine());

            decimal salario;
            Write("Salário (ex: 1500.50): ");
            while (!decimal.TryParse(ReadLine(), out salario))
            {
                Write("Valor inválido! Digite novamente (ex: 1500.50): ");
            }
            funcionario.setSalario(salario);

            WriteLine("\nEndereço do funcionário:");
            Write("Estado: ");
            endereco.setEstado(ReadLine());
            Write("Cidade: ");
            endereco.setCidade(ReadLine());
            Write("Bairro: ");
            endereco.setBairro(ReadLine());
            Write("CEP: ");
            endereco.setCep(ReadLine());
            Write("Logradouro: ");
            endereco.setLogradouro(ReadLine());
            Write("Complemento: ");
            endereco.setComplemento(ReadLine());
            Write("Número: ");
            endereco.setNumero(ReadLine());

            funcionario.setEndereco(endereco);

            //quarto
            Clear();
            WriteLine("Cadastro de Quarto");
            WriteLine();

            int numeroQuarto;
            Write("Número do quarto: ");
            while (!int.TryParse(ReadLine(), out numeroQuarto))
            {
                Write("Valor inválido! Digite um número inteiro: ");
            }
            quarto.setNumQuarto(numeroQuarto);

            Write("Descrição do quarto: ");
            quarto.setDescricao(ReadLine());

            Write("Categoria do quarto: ");
            quarto.setCategoria(ReadLine());

            int qtdCamas;
            Write("Quantidade de camas: ");
            while (!int.TryParse(ReadLine(), out qtdCamas))
            {
                Write("Valor inválido! Digite um número inteiro: ");
            }
            quarto.setQtdCamas(qtdCamas);

            //servicos
            Clear();
            WriteLine("Cadastro de Serviço");
            WriteLine();

            Write("Descrição do serviço: ");
            servico.setDescricao(ReadLine());

            decimal valorServico;
            Write("Valor do serviço (ex: 199.90): R$ ");
            while (!decimal.TryParse(ReadLine(), out valorServico))
            {
                Write("Valor inválido! Digite novamente (ex: 199.90): R$ ");
            }
            servico.setValor(valorServico);

            Write("Categoria do serviço: ");
            servico.setCategoria(ReadLine());

            Write("O serviço está ativo? (1 - Sim | 0 - Não): ");
            int opcao;
            while (!int.TryParse(ReadLine(), out opcao) || (opcao != 0 && opcao != 1))
            {
                Write("Entrada inválida! Digite 1 para Sim ou 0 para Não: ");
            }
            servico.setAtivo(opcao == 1);

            //reserva
            Clear();
            WriteLine("Cadastro de Reserva");
            WriteLine();

            Write("Descrição da reserva: ");
            reserva.setDescricao(ReadLine());

            Write("Data da reserva (DD/MM/AAAA): ");
            reserva.setDataAplicacao(ReadLine());

            WriteLine("\nInformações do quarto para reserva:");
            Write("Número do quarto: ");
            while (!int.TryParse(ReadLine(), out numeroQuarto))
            {
                Write("Valor inválido! Digite um número inteiro: ");
            }
            quarto.setNumQuarto(numeroQuarto);

            Write("Categoria: ");
            quarto.setCategoria(ReadLine());

            Write("Quantidade de camas: ");
            while (!int.TryParse(ReadLine(), out qtdCamas))
            {
                Write("Valor inválido! Digite um número inteiro: ");
            }
            quarto.setQtdCamas(qtdCamas);

            reserva.setQuarto(quarto);

            decimal valorDiaria;
            Write("Valor da diária (ex: 350.00): R$ ");
            while (!decimal.TryParse(ReadLine(), out valorDiaria))
            {
                Write("Valor inválido! Digite novamente (ex: 350.00): R$ ");
            }
            reserva.setValorDiaria(valorDiaria);

            //dados do serviço na reserva
            Clear();
            WriteLine("Informações do Serviço incluso na reserva");
            Write("Descrição do serviço: ");
            servico.setDescricao(ReadLine());

            Write("Valor do serviço (ex: 80.00): R$ ");
            while (!decimal.TryParse(ReadLine(), out valorServico))
            {
                Write("Valor inválido! Digite novamente (ex: 80.00): R$ ");
            }
            servico.setValor(valorServico);

            reserva.setServicos(servico);

            //cálculo do valor total
            decimal valorTotal = reserva.getValorDiaria() + reserva.getServicos().getValor();
            reserva.setValorTotal(valorTotal);

            Clear();
            WriteLine("Dados do hotel: ");
            WriteLine("Nome do hotel: {0}", hotel.getNomeCompleto());
            WriteLine("Nome da empresa: {0}", hotel.getNomeEmpresa());
            WriteLine("data da fundação: {0}", hotel.getDataFundacao());
            WriteLine("email corporativo: {0}", hotel.getEmailCorporativo());
            WriteLine("Endereço:");
            WriteLine(" - Estado: {0}", hotel.GetEndereco().getEstado());
            WriteLine(" - Cidade: {0}", hotel.GetEndereco().getCidade());
            WriteLine(" - Bairro: {0}", hotel.GetEndereco().getBairro());
            WriteLine(" - Cep: {0}", hotel.GetEndereco().getCep());
            WriteLine(" - Logradouro: {0}", hotel.GetEndereco().getLogradouro());
            WriteLine(" - Complemento: {0}", hotel.GetEndereco().getComplemento());
            WriteLine(" - Numero: {0}", hotel.GetEndereco().getNumero());
            WriteLine();

            WriteLine("Dados do Cliente:");
            WriteLine("Nome: {0}", cliente.getNome());
            WriteLine("Código: {0}", cliente.getCodigo());
            WriteLine("Profissão: {0}", cliente.getProfissao());
            WriteLine("RG: {0}", cliente.getRg());
            WriteLine("CPF: {0}", cliente.getCpf());
            WriteLine("Endereço:");
            WriteLine(" - Estado: {0}", cliente.getEndereco().getEstado());
            WriteLine(" - Cidade: {0}", cliente.getEndereco().getCidade());
            WriteLine(" - Bairro: {0}", cliente.getEndereco().getBairro());
            WriteLine(" - CEP: {0}", cliente.getEndereco().getCep());
            WriteLine(" - Logradouro: {0}", cliente.getEndereco().getLogradouro());
            WriteLine(" - Complemento: {0}", cliente.getEndereco().getComplemento());
            WriteLine(" - Número: {0}", cliente.getEndereco().getNumero());
            WriteLine();

            WriteLine("Dados do Funcionário:");
            WriteLine("Nome: {0}", funcionario.getNome());
            WriteLine("Código: {0}", funcionario.getCodigo());
            WriteLine("RG: {0}", funcionario.getRg());
            WriteLine("CPF: {0}", funcionario.getCpf());
            WriteLine("Salário: {0:C}", funcionario.getSalario());
            WriteLine("Endereço:");
            WriteLine(" - Estado: {0}", funcionario.GetEndereco().getEstado());
            WriteLine(" - Cidade: {0}", funcionario.GetEndereco().getCidade());
            WriteLine(" - Bairro: {0}", funcionario.GetEndereco().getBairro());
            WriteLine(" - CEP: {0}", funcionario.GetEndereco().getCep());
            WriteLine(" - Logradouro: {0}", funcionario.GetEndereco().getLogradouro());
            WriteLine(" - Complemento: {0}", funcionario.GetEndereco().getComplemento());
            WriteLine(" - Número: {0}", funcionario.GetEndereco().getNumero());
            WriteLine();

            WriteLine("Dados do Quarto:");
            WriteLine("Número: {0}", quarto.getNumQuarto());
            WriteLine("Descrição: {0}", quarto.getDescricao());
            WriteLine("Categoria: {0}", quarto.getCategoria());
            WriteLine("Quantidade de camas: {0}", quarto.getQtdCamas());
            WriteLine();

            WriteLine("Dados do Serviço:");
            WriteLine("Descrição: {0}", servico.getDescricao());
            WriteLine("Valor: {0:C}", servico.getValor());
            WriteLine("Categoria: {0}", servico.getCategoria());
            WriteLine("Status: {0}", servico.getAtivo() ? "Ativo" : "Inativo");
            WriteLine();

            WriteLine("Dados da Reserva:");
            WriteLine("Descrição: {0}", reserva.getDescricao());
            WriteLine("Data: {0}", reserva.getDataAplicacao());

            WriteLine();
            WriteLine("Quarto:");
            WriteLine(" - Número: {0}", reserva.getQuarto().getNumQuarto());
            WriteLine(" - Categoria: {0}", reserva.getQuarto().getCategoria());
            WriteLine(" - Camas: {0}", reserva.getQuarto().getQtdCamas());

            WriteLine();
            WriteLine("Serviço:");
            WriteLine(" - Descrição: {0}", reserva.getServicos().getDescricao());
            WriteLine(" - Valor: {0:C}", reserva.getServicos().getValor());

            WriteLine();
            WriteLine("Valores:");
            WriteLine(" - Diária: {0:C}", reserva.getValorDiaria());
            WriteLine(" - Total: {0:C}", reserva.getValorTotal());

            ReadKey();
        }
    }
}
