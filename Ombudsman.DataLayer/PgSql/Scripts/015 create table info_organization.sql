-- Table: public.info_organization

-- DROP TABLE IF EXISTS public.info_organization;

CREATE TABLE IF NOT EXISTS public.info_organization
(
    id serial primary key,
    government_organization_type_id integer NOT NULL
            REFERENCES public.enum_government_organization_type (id),
    is_grouper boolean NOT NULL,
    superior_organization_id integer NOT NULL  REFERENCES public.info_organization (id),
    state_id integer NOT NULL REFERENCES public.enum_state (id),
    full_name varchar(100) NOT NULL,
    short_name varchar(100) NOT NULL,
    created_date timestamp without time zone NOT NULL,
    created_user_id integer NOT NULL,
    updated_date timestamp without time zone,
    updated_user_id integer)

