Princ�pio da Responsabilidade �nica (Single Responsibility Principle)
Uma Classe deve ter apenas uma responsabilidade

A viola��o do Single Responsibility Principle pode gerar alguns problemas, sendo eles:

 * *Falta de coes�o � uma classe n�o deve assumir responsabilidades que n�o s�o suas;
 * *Alto acoplamento � Mais responsabilidades geram um maior n�vel de depend�ncias, deixando o sistema engessado e fr�gil para altera��es;
 * *Dificuldades na implementa��o de testes automatizados � � dif�cil de �mockar� esse tipo de classe;
 * *Dificuldades para reaproveitar o c�digo;



 --------------------------
 Vemos agora que a Classe GerenciarTarefasFull tem muitas responsabilidades e isso quebra o principio da Responsabilidade �nica, aonde atrapalaha ate na manuten��o de c�digo