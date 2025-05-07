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
            WriteLine("Cadastro hotel");
            WriteLine();

            Write("nome do hotel: ");
            hotel.setNomeCompleto(ReadLine());

            Write("nome da empresa: ");
            hotel.setNomeEmpresa(ReadLine());

            Write("data da fundação: ");
            hotel.setDataFundacao(ReadLine());

            Write("email do hotel: ");
            hotel.setEmailCorporativo(ReadLine());

            WriteLine("Endereco: ");
            Write("estado: ");
            endereco.setEstado(ReadLine());
            Write("cidade: ");
            endereco.setCidade(ReadLine());
            Write("bairro: ");
            endereco.setBairro(ReadLine());
            Write("cep: ");
            endereco.setCep(ReadLine());
            Write("logradouro: ");
            endereco.setLogradouro(ReadLine());
            Write("complemento: ");
            endereco.setComplemento(ReadLine());
            Write("numero: ");
            endereco.setNumero(ReadLine());

            hotel.setEndereco(endereco);


            //cliente
            Clear();
            WriteLine("Cliente:");
            WriteLine();

            Write("Nome do cliente: ");
            cliente.setNome(ReadLine());

            Write("Código do cliente: ");
            cliente.setCodigo(ReadLine());

            Write("Profissão: ");
            cliente.setProfissao(ReadLine());

            Write("RG: ");
            cliente.setRg(ReadLine());

            Write("CPF: ");
            cliente.setCpf(ReadLine());

            WriteLine("Endereço do cliente: ");
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
            WriteLine("Cadastro de Funcionário");
            WriteLine();

            Write("Nome do funcionário: ");
            funcionario.setNome(ReadLine());

            Write("Código do funcionário: ");
            funcionario.setCodigo(ReadLine());

            Write("RG: ");
            funcionario.setRg(ReadLine());

            Write("CPF: ");
            funcionario.setCpf(ReadLine());

            Write("Salário: ");
            funcionario.setSalario(decimal.Parse(ReadLine()));

            WriteLine("Endereço do funcionário: ");
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
            WriteLine("Quarto:");
            WriteLine();

            Write("Número do quarto: ");
            quarto.setNumQuarto(int.Parse(ReadLine()));

            Write("Descrição: ");
            quarto.setDescricao(ReadLine());

            Write("Categoria: ");
            quarto.setCategoria(ReadLine());

            Write("Quantidade de camas: ");
            quarto.setQtdCamas(int.Parse(ReadLine()));

            //servicos
            Clear();
            WriteLine("Serviços: ");
            WriteLine();

            Write("Descrição do serviço: ");
            servico.setDescricao(ReadLine());

            Write("Valor do serviço: ");
            servico.setValor(decimal.Parse(ReadLine()));

            Write("Categoria do serviço: ");
            servico.setCategoria(ReadLine());

            Write("O serviço está ativo?: \n1.Sim\n0.Não");
            int opcao;
            while (!int.TryParse(ReadLine(), out opcao) || (opcao != 0 && opcao != 1))
            {
                Write("São permitidos somente 0 ou 1, 1 - ativo / 0 - inativo");
            }
            servico.setAtivo(opcao == 1);



            WriteLine("\nCadastro de Reserva");
            WriteLine();

            // Dados básicos da reserva
            Write("Descrição da reserva: ");
            reserva.setDescricao(ReadLine());

            Write("Data da reserva (DD/MM/AAAA): ");
            reserva.setDataAplicacao(ReadLine());

            // Cadastro do quarto para a reserva
            WriteLine("\nDados do Quarto:");
            Write("Número do quarto: ");
            quarto.setNumQuarto(int.Parse(ReadLine()));

            Write("Categoria: ");
            quarto.setCategoria(ReadLine());

            Write("Quantidade de camas: ");
            quarto.setQtdCamas(int.Parse(ReadLine()));

            reserva.setQuarto(quarto);

            // Valor da diária
            Write("Valor da diária: R$ ");
            reserva.setValorDiaria(decimal.Parse(ReadLine()));

            // Cadastro de serviço para a reserva
            WriteLine("\nDados do Serviço:");
            Write("Descrição do serviço: ");
            servico.setDescricao(ReadLine());

            Write("Valor do serviço: R$ ");
            servico.setValor(decimal.Parse(ReadLine()));

            reserva.setServicos(servico);

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

            WriteLine("Dados da Reserva:");
            WriteLine("Descrição: {0}", reserva.getDescricao());
            WriteLine("Data: {0}", reserva.getDataAplicacao());

            WriteLine("\nQuarto:");
            WriteLine(" - Número: {0}", reserva.getQuarto().getNumQuarto());
            WriteLine(" - Categoria: {0}", reserva.getQuarto().getCategoria());
            WriteLine(" - Camas: {0}", reserva.getQuarto().getQtdCamas());

            WriteLine("\nServiço:");
            WriteLine(" - Descrição: {0}", reserva.getServicos().getDescricao());
            WriteLine(" - Valor: {0:C}", reserva.getServicos().getValor());

            WriteLine("\nValores:");
            WriteLine(" - Diária: {0:C}", reserva.getValorDiaria());
            WriteLine(" - Total: {0:C}", reserva.getValorTotal());

        }
    }
}
