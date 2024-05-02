Princípio da Responsabilidade Única (Single Responsibility Principle)
Uma Classe deve ter apenas uma responsabilidade

A violação do Single Responsibility Principle pode gerar alguns problemas, sendo eles:

 * *Falta de coesão — uma classe não deve assumir responsabilidades que não são suas;
 * *Alto acoplamento — Mais responsabilidades geram um maior nível de dependências, deixando o sistema engessado e frágil para alterações;
 * *Dificuldades na implementação de testes automatizados — É difícil de “mockar” esse tipo de classe;
 * *Dificuldades para reaproveitar o código;



 --------------------------
 Vemos agora que a Classe GerenciarTarefasFull tem muitas responsabilidades e isso quebra o principio da Responsabilidade única, aonde atrapalaha ate na manutenção de código