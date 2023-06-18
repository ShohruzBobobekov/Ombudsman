			   -- Table: public.doc_document_realization

-- DROP TABLE IF EXISTS public.doc_document_realization;

CREATE TABLE IF NOT EXISTS public.doc_document_realization
(
    id serial primary key,
    document_speciality varchar(200) NOT NULL,
    is_included_in_state_program boolean NOT NULL,
    state_program_name varchar(200),
    document_summary varchar(1000),
    sent_date date NOT NULL,
    responsible_sector_id integer NOT NULL  REFERENCES public.info_sector (id),
    main_ministry varchar(200) NOT NULL,
    main_realizer varchar(200) NOT NULL,
    additional_realizers varchar(200) NOT NULL,
    initiative varchar(200) NOT NULL,
    doc_number varchar(200),
    doc_date date,
    file_id uuid REFERENCES public.sys_file (id),
    document_type_id integer NOT NULL REFERENCES public.enum_document_type (id),
    importance_id integer NOT NULL  REFERENCES public.info_document_importance (id),
    initiative_type_id integer NOT NULL REFERENCES public.enum_initiative_type (id),
    state_id integer NOT NULL  REFERENCES public.enum_state (id),
    full_name varchar(200) NOT NULL,
    short_name varchar(200) NOT NULL,
    created_at timestamp without time zone NOT NULL,
    created_user_id integer,
    updated_at timestamp without time zone,
    updated_user_id integer
)