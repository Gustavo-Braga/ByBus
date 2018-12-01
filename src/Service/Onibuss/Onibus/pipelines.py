# -*- coding: utf-8 -*-

# Define your item pipelines here
#
# Don't forget to add your pipeline to the ITEM_PIPELINES setting
# See: https://doc.scrapy.org/en/latest/topics/item-pipeline.html
import sqlite3
import scrapy

class OnibusPipeline(object):

    def process_item(self, item, spider):
        self.conn.execute(
            'insert into Empresa() values (:CNPJ, :nome)',
            'insert into Linha() values (:nome, :CNPJ)',
            'insert into Onibus() values (:CNPJ, :IdLinha)',
            'insert into Segmento() values (:IdLinha, :nome, :logradouro)',
            'insert into TipoDia() values(:Tipo)',
            'insert into Horario() value(:IdSegmento, :IdTipoDIa, :tabelaHoras)',
            item
        )
        self.conn.commit()
        return item

    def create_table(self):
        result = self.conn.execute(
            'select name from sqlite_master where type = "table" and name = "Empresa", name = "Linha", name = "Onibus", name = "Segmento", name = "TipoDia", name = "Horario"'
        )
        try:
            value = next(result)
        except StopIteration as ex:
            self.conn.execute(
                'create table Empresa(CNPJ text PRIMARY KEY, nome text NOT NULL)',
                'create table Linha(id INTEGER PRIMARY KEY, nome text not null, CNPJ text, foreign key (CNPJ) references Empresa (CNPJ))',
                'create table Onibus(id INTEGER PRIMARY KEY, CNPJ text, IdLinha integer, foreign key (CNPJ) references Empresa (CNPJ), foreign key (IdLinha) references Linha(id))',
                'create table Segmento(id INTEGER PRIMARY KEY, IdLinha integer, nome text, logradouro text, foreign key (IdLinha) references Linha(id))',
                'create table TipoDia (id INTEGER PRIMARY KEY, Tipo text)',
                'create table Horario(id INTEGER PRIMARY KEY, IdSegmento integer, IdTipoDia integer, tabelaHoras text, foreign key (IdSegmento) references Segmento(id), foreign key (IdTipoDia) references TipoDia (id))'
            )

    def open_spider(self, spider):
        self.conn = sqlite3.connect('db.Onibus')
        self.create_table()

    def close_spider(self, spider):
        self.conn.close()

# class OnibusPipeline(object):
 
    # def process_item(self, item, spider):

        # try:
        #     self.cursor.execute(
        #         "INSERT INTO Empresa(CNPJ, name) VALUES (:CNPJ, :name)", 
        #         item
        #     )
        #     self.conn.commit()

            

    #     try:
    #         self.cursor.execute(
    #             "INSERT INTO TipoDia(Tipo text) VALUES (:Tipo)", 
    #             item
    #         )
    #         self.conn.commit()

    #     try:
    #         self.conn.execute(
    #             "INSERT INTO Horarios(Horario text) VALUES (:Horario)",
    #             item
    #         )
    #         self.conn.commit()

    #     try:
    #         self.conn.execute(
    #             "INSERT INTO Linha(Nome text, CPNJ integer) VALUES (:Nome, :CNPJ)"
    #         )
    #         self.conn.commit()

    #    try:
    #         self.cursor.execute(
    #             "INSERT INTO Onibus(CodOnibus, CNPJ) VALUES (:CodOnibus, :CNPJ)"
    #         )
    #         self.conn.commit()

    #     try:
    #         self.cursor.execute(
    #             "INSERT INTO Emp_Lin_Oni(CNPJ, CodOnibus, IdLinha) VALUES(:CNPJ, :CodOnibus, :idLinha)  "
    #         )
    #         self.conn.commit()

    #     try:
    #         self.cursor.execute(
    #             "INSERT INTO Segmento(Logradouro text, Nome text, Sequencia text, IdLinha integer) VALUES (:Logradouro, :Nome, :Sequencia, :IdLinha)"
    #         )
    #         self.conn.commit()

    #     try:
    #         self.cursor.execute(
    #             "INSERT INTO Horario(IdSegmento integer, IdHorario integer, IdTipoDia integer) VALUES (:IdSegmento, :IdHorario, :IdTipoDia)"
    #         )
    #         self.conn.commit()


        # return item

    # def create_table(self):
    #     result = self.conn.execute
    #     (           
    #         'select name from sqlserver_master where type = "table" and name "Empresa"'
    #         'select name from sqlserver_master where type = "table" and name "TipoDia"'
    #         'select name from sqlserver_master where type = "table" and name "Horarios"'
    #         'select name from sqlserver_master where type = "table" and name "Linha"'
    #         'select name from sqlserver_master where type = "table" and name "Onibus"'
    #         'select name from sqlserver_master where type = "table" and name "Emp_Lin_Oni"'
    #         'select name from sqlserver_master where type = "table" and name "Segmento"'
    #         'select name from sqlserver_master where type = "table" and name "Horario"'            
    #     )
    #     try:
    #         value = next(result)
    #     except StopIteration as ex:

    #         self.conn.execute(
    #             'create table Empresa(CNPJ integer primary key, Nome text)'
    #         )
    #         self.conn.execute(
    #             'create table TipoDia(IdTipoDia integer primary key, Tipo text)'
    #         )
    #         self.conn.execute(
    #             'create table Horarios(IdHorario integer primary key, Horario text)'
    #         )
    #         self.conn.execute(
    #             'create table Linha(IdLinha integer primary key, Nome text, CPNJ integer foreign key(CNPJ) references Empresa(CNPJ))'
    #         )
    #         self.conn.execute(
    #             'create table Onibus(CodOnibus integer primary key, CNPJ integer foreign key(CNPJ) references Empresa(CNPJ), IdLinha integer foreign key(IdLinha) references Linha(IdLinha))'
    #         )   
    #         self.conn.execute(
    #             'create table Emp_Lin_Oni(CNPJ integer primary key, IdLinha integer primary key, CodOnibus integer primary key)'
    #         )           
    #         self.conn.execute(
    #             'create table Segmento(IdSegmento integer primary key, Logradouro text, Nome text, Sequencia text, IdLinha integer foreign key(IdLinha) references Linha(IdLinha))'
    #         )            
    #         self.conn.execute(
    #             'create table Horario(IdSegmento integer foreign key(IdSegmento) references Segmento(IdSegmento), IdHorario integer foreign key(IdHorario) references Horario(IdHorario), IdTipoDia integer foreign key(IdTipoDia) references TipoDia(IdTipoDia))'
    # #         )

    # def open_spider(self, spider):
    #     self.conn = pyodbc.connect('db.Onibus')
    #     self.create_table()

    # def close_spider(self, spider):
    #     self.conn.close()


# dsn =  ' sqlserverdatasource '
# user =  ' <nome de usuário> '
# senha =  ' <senha> '
# database =  ' <dbname> '

# con_string =  ' DSN = % s ; UID = % s ; PWD = % s ; BANCO DE DADOS = % s ; '  % (dsn, usuário, senha, banco de dados)
    # cnxn = pyodbc.connect (con_string)