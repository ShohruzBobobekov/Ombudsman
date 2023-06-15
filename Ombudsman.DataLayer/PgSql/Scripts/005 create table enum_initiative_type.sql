-- Table: public.enum_initiative_type

-- DROP TABLE IF EXISTS public.enum_initiative_type;

CREATE TABLE IF NOT EXISTS public.enum_initiative_type
(
    id serial primary key,
    short_name text COLLATE pg_catalog."default" NOT NULL,
    full_name text COLLATE pg_catalog."default" NOT NULL
)