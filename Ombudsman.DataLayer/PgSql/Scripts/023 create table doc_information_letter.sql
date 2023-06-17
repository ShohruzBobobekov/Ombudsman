-- Table: public.doc_information_letter

-- DROP TABLE IF EXISTS public.doc_information_letter;

CREATE TABLE IF NOT EXISTS public.doc_information_letter
(
    id serial primary key,
    doc_number varchar(100),
    doc_date date,
    information_letter_text varchar(5000) NOT NULL,
    main_realizer varchar(100) NOT NULL,
    additional_realizers varchar(100) NOT NULL,
    responsible_employee_full_name varchar(100) NOT NULL,
    phone_number varchar(20) NOT NULL,
    owner_id integer NOT NULL REFERENCES public.doc_document_realization (id),
    full_name varchar(100) NOT NULL,
    short_name varchar(100) NOT NULL,
    created_date timestamp without time zone NOT NULL,
    created_user_id integer NOT NULL,
    updated_date timestamp without time zone NOT NULL,
    updated_user_id integer
)