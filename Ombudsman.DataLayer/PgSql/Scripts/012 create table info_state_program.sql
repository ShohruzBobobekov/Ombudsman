-- Table: public.info_state_program

-- DROP TABLE IF EXISTS public.info_state_program;

CREATE TABLE IF NOT EXISTS public.info_state_program
(
    id serial primary key,
    order_number text COLLATE pg_catalog."default" NOT NULL,
    short_name text COLLATE pg_catalog."default" NOT NULL,
    full_name text COLLATE pg_catalog."default" NOT NULL,
    state_id integer NOT NULL,
    CONSTRAINT fk_info_state_program_enum_state_state_id FOREIGN KEY (state_id)
        REFERENCES public.enum_state (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)