# -*- coding: utf-8 -*-
import scrapy
import Segmento from Onibus
import TipoDia from Onibus
import Horarios from Onibus
import Empresa from Onibus

class LinhasSpider(scrapy.Spider):

    name = 'Linhas'    
    start_urls = ['http://www.ctaonline.com.br/index.php/linhas.html']

    ##EMPRESA e LINKS
    def parse_links(self, response):
    empresa = response.xpath('//div[contains(@class, "grid3 column first last ex-odd multi-module-column sidebar-a")]')
    for cat in empresa:
        empresa_cruz = cat.xpath('//div[contains(@class,"block module mod-87 clearfix")]//h2/text()').extract_first()        
        viacao_paraty = cat.xpath('//div[contains(@class,"block module mod-88 clearfix")]//h2/text()').extract_first()        
        paraty = cat.xpath('//div[contains(@class,"block module mod-95 clearfix")]//h2/text()').extract_first()
        teste = cat.xpath('//div[contains(@class, "block module")]/div[contains(@class, "content")]/ul')
        for link in teste:
            links = teste.xpath('//li[contains(@class, "item")]/a')
            for li in links:
                link = li.xpath('./@href').extract_first()  
                yield scrapy.Request (
                    Empresa.Empresa.Nome = empresa_cruz, viacao_paraty, paraty
                    url =  link,
                    callback=self.parse_paginas
                    )

    def parse_paginas(self, response, url):        
        yield scrapy.Request(
            'http://www.ctaonline.com.br%s' %url, 
            callback=self.parse_conteudo
        )
                      
        
            # yield scrapy.Request(
            #     link = 'http://www.ctaonline.com.br%s' % link,               
            #     callback=self.parse_category
            # )

            # yield scrapy.Request(
            #     link = next_page.extract_first(), callback = self.parse_links
            # )
            
    def parse_conteudo(self, response):

        ##pagina toda 
        itinerarios = response.xpath('//*[contains(@class, "wpb_column vc_column_container vc_col-sm-12")]')    
        ##Linha nome
        title = response.xpath('//*[@id="component"]/div/article/header/h1/a/text()').extract_first()  


        ##Segmento nome
        for seg in itinerarios:
            nome = seg.xpath('//div[contains(@class, "wpb_wrapper")]/p/span')
            for segg in nome:
                segmento = segg.xpath('./text()').extract_first()
                if segmento != None:
                    yield scrapy.Request(
                        Segmento.Segmento.Nome = segmento
                    )              
        ##Rotas
        for iot in itinerarios:
            rota = iot.xpath('//div[contains(@class, "wpb_wrapper")]/p')
            for iott in rota:
                Rotas = iott.xpath('./text()').extract_first()
                if Rotas != None:
                    yield scrapy.Request(
                        Segmento.Segmento.Logradouro = Rotas
                    )                   

        ##Tipo Dia
        for p in itinerarios:
            var = p.xpath('.//p')
            for pp in var:
                organiza_horarios = pp.xpath('.//span/text()').extract()
                yield scrapy.Request(
                    TipoDia.TipoDia.Tipo = organiza_horarios
                )
              

        ##Horários
        for p in itinerarios:
            var = p.xpath('.//table')
            for pp in var:
                var1 = pp.xpath('.//tr')
                for ppp in var1:
                    horarios = ppp.xpath('.//td/span/text()').extract_first()
                    yield scrapy.Request(
                        Horarios.Horarios.hora = horarios
                    )
                   
        yield scrapy.Request (
            callback=self.parse_conteudo
        )
      

    # for iot in itinerarios:
    #     teste = iot.xpath('//div[contains(@class, "wpb_wrapper")]/p[1]/text()').extract_first()

