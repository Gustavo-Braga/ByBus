import scrapy
import Empresa from Onibus 
import Linhas from Onibus 

class Linha(scrapy.Item):
 
    Nome = scrapy.Field()
    CNPJ = Empresa.CNPJ
      

'create table Linha(id INTEGER PRIMARY KEY, nome text not null, CNPJ text, foreign key (CNPJ) references Empresa (CNPJ))',