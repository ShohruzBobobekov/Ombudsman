-- Table: public.enum_document_type

-- DROP TABLE IF EXISTS public.enum_document_type;

CREATE TABLE IF NOT EXISTS public.enum_document_type
(
    id serial primary key,
    order_number character varying,
    short_name character varying,
    full_name character varying,
    state_id integer NOT NULL,
    CONSTRAINT fk_enum_document_type_enum_state_state_id FOREIGN KEY (state_id)
        REFERENCES public.enum_state (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)
