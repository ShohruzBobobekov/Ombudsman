-- Table: public.doc_information_letter_table

-- DROP TABLE IF EXISTS public.doc_information_letter_table;

CREATE TABLE IF NOT EXISTS public.hl_employee
(
    id serial primary key,
    first_name varchar(100) NOT NULL,
    last_name varchar(100) NOT NULL,
    organization_id integer NOT NULL,
    position varchar(100) NOT NULL,
    salary numeric,
    phone_number varchar(20),
    created_at timestamp without time zone NOT NULL,
    created_user_id integer,
    updated_at timestamp without time zone ,
    updated_user_id integer
)