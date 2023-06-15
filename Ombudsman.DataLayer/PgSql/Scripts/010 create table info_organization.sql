-- Table: public.info_organization

-- DROP TABLE IF EXISTS public.info_organization;

CREATE TABLE IF NOT EXISTS public.info_organization
(
    id serial primary key,
    government_organization_type_id integer NOT NULL,
    is_grouper boolean NOT NULL,
    superior_organization_id integer NOT NULL,
    state_id integer NOT NULL,
    full_name text COLLATE pg_catalog."default" NOT NULL,
    short_name text COLLATE pg_catalog."default" NOT NULL,
    created_date timestamp with time zone NOT NULL,
    created_user_id integer NOT NULL,
    updated_date timestamp with time zone NOT NULL,
    updated_user_id integer,
    CONSTRAINT fk_info_organization_enum_government_organization_type_governm FOREIGN KEY (government_organization_type_id)
        REFERENCES public.enum_government_organization_type (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE,
    CONSTRAINT fk_info_organization_enum_state_state_id FOREIGN KEY (state_id)
        REFERENCES public.enum_state (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE,
    CONSTRAINT fk_info_organization_info_organization_superior_organization_id FOREIGN KEY (superior_organization_id)
        REFERENCES public.info_organization (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)

