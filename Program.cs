
class Program{
    static void Main(){

        string senha = "567";
        string? senhauser;
        int tentativas = 3;
        do
        {
            Console.Clear();
            Console.Write("Digite a senha: ");
            senhauser = Console.ReadLine();
            tentativas++;
        } while (senha != senhauser);
        Console.Clear();
         if(tentativas>3){
            Console.Write("Conta Bloqueada");
        }else{Console.WriteLine($"Senha correta! tentativas: {tentativas}");
       }
        
    }
}
