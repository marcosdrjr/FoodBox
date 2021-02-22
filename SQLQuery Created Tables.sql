Create Table product 
(
	id_product int primary key identity
	,name varchar(100)
	,value numeric(20,5)
	,description  varchar(500)
	,expiration_date datetime
	,create_at datetime
	,update_at datetime
	,status bit default cast(1 as bit)
)

Create Table snacks 
(
	id_snacks int primary key identity
	,name varchar(100)
	,description  varchar(500)
	,create_at datetime
	,update_at datetime
	,status bit default cast(1 as bit)
)

Create Table produc_snacks 
(
	id_product_snacks int primary key identity
	,id_snacks int CONSTRAINT FK_id_snacks_produc_snacks  FOREIGN KEY (id_snacks) REFERENCES snacks(id_snacks) 
	,id_product int CONSTRAINT FK_id_product_produc_snacks  FOREIGN KEY (id_product) REFERENCES product(id_product) 
	,name varchar(100)
	,description  varchar(500)
	,create_at datetime
	,update_at datetime
	,status bit default cast(1 as bit)
)


Create Table status_solicitation 
(
	id_status_solicitation int primary key identity
	,name varchar(100)
	,create_at datetime
	,update_at datetime
	,status bit default cast(1 as bit)
)

Create Table solicitation_food 
(
	id_solicitation_food int primary key identity
	,id_snacks int CONSTRAINT FK_id_snacks_solicitation_food  FOREIGN KEY (id_snacks) REFERENCES snacks(id_snacks) 
	,id_status_solicitation int CONSTRAINT FK_id_status_solicitation_solicitation_food  FOREIGN KEY (id_status_solicitation) REFERENCES status_solicitation(id_status_solicitation) 
	,value numeric(20,5)
	,create_at datetime
	,update_at datetime
	,status bit default cast(1 as bit)
)

