-- Table: public.enum_language

-- DROP TABLE IF EXISTS public.enum_language;

CREATE TABLE IF NOT EXISTS public.enum_language
(
    id integer primary key,
    short_name varchar(100) NOT NULL,
    full_name varchar(100) NOT NULL
)
