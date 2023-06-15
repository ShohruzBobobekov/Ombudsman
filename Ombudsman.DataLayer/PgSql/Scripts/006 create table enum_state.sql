-- Table: public.enum_state

-- DROP TABLE IF EXISTS public.enum_state;

CREATE TABLE IF NOT EXISTS public.enum_state
(
    id serial primary key,
    short_name text COLLATE pg_catalog."default" NOT NULL,
    full_name text COLLATE pg_catalog."default" NOT NULL
)