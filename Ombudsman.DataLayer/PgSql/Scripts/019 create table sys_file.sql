-- Table: public.sys_file

-- DROP TABLE IF EXISTS public.sys_file;

CREATE TABLE IF NOT EXISTS public.sys_file
(
    id uuid NOT NULL PRIMARY KEY,
    name varchar(100) NOT NULL,
    extension varchar(10) NOT NULL
)