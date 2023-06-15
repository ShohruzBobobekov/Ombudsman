-- Table: public.sys_file

-- DROP TABLE IF EXISTS public.sys_file;

CREATE TABLE IF NOT EXISTS public.sys_file
(
    id uuid NOT NULL,
    name text COLLATE pg_catalog."default" NOT NULL,
    extension text COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT pk_sys_file PRIMARY KEY (id)
)