-- Table: public.enum_language

-- DROP TABLE IF EXISTS public.enum_language;

CREATE TABLE IF NOT EXISTS public.enum_language
(
    id serial primary key,
    short_name text COLLATE pg_catalog."default" NOT NULL,
    full_name text COLLATE pg_catalog."default" NOT NULL
)
