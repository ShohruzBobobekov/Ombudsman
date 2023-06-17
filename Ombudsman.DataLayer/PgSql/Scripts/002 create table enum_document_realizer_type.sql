-- Table: public.enum_document_realizer_type

-- DROP TABLE IF EXISTS public.enum_document_realizer_type;

CREATE TABLE IF NOT EXISTS public.enum_document_realizer_type
(
    id integer primary key,
    order_number varchar(100) NOT NULL,
    short_name varchar(100) NOT NULL,
    full_name varchar(100) NOT NULL,
    state_id integer NOT NULL REFERENCES public.enum_state (id)
)