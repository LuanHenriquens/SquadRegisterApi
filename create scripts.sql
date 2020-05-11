create schema squad_register;

CREATE SEQUENCE squad_register.squad_id_seq;

create table squad_register.squad (
	id integer NOT NULL DEFAULT nextval('squad_register.squad_id_seq'),
	name varchar(50),
	create_date date,
	description varchar(255),
	primary key (id)
);

ALTER SEQUENCE squad_register.squad_id_seq
OWNED BY squad_register.squad.id;


CREATE SEQUENCE squad_register.member_id_seq;

create table squad_register.member (
	id integer NOT NULL DEFAULT nextval('squad_register.member_id_seq'),
	name varchar(100),
	create_date date,
	function varchar(50),
	squad_id integer,
	primary key (id),
	FOREIGN KEY (squad_id) REFERENCES squad_register.squad(id)
);

ALTER SEQUENCE squad_register.member_id_seq
OWNED BY squad_register.member.id;
