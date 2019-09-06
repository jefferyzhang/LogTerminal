# LogTerminal
现在企业级Java微服务项目的日志系统经常基于ELK，它非常强大，但也非常重量级，要跑起来需要较高的服务器配置。但对于一些环境比如测试环境，预上线环境 的服务器资源比较低，而且我们对日志服务的要求也比较低，因此 有必要在这些环境 选择一个轻量级的日志架构。经过一些调研，有了下面这样一个想法：  

![image](https://github.com/jefferyzhang/LogTerminal/blob/master/flow.png)

其中，LogTerminal就是一个日志终端，可以通过它来轻松查看日志。它提供了两种模式：  
1.控制台模式，用于查看最新的日志：
![image](https://github.com/jefferyzhang/LogTerminal/blob/master/console.png)

2.查询模式，查询最近的日志：
![image](https://github.com/jefferyzhang/LogTerminal/blob/master/search.png)
