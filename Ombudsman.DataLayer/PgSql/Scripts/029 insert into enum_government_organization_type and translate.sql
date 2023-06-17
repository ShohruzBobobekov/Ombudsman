INSERT INTO enum_government_organization_type
(id,order_number, short_name, full_name,state_id)
VALUES (1, '001', 'Вазирлик', 'Вазирлик',1);

INSERT INTO enum_government_organization_type_translate 
(owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (1, 1, 'full_name', 'Вазирлик'),
  -- Uzbek Latin translations
  (1, 2, 'full_name', 'Vazirlik'),
  -- Russian translations
  (1, 3, 'full_name', 'Mинистерство');
  
 
INSERT INTO enum_government_organization_type
(id,order_number, short_name, full_name,state_id)
VALUES (2, '002', 'Алоҳида мақомга эга мустақил орган', 'Алоҳида мақомга эга мустақил орган',1);

INSERT INTO enum_government_organization_type_translate 
(owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (1, 1, 'full_name', 'Алоҳида мақомга эга мустақил орган'),
  -- Uzbek Latin translations
  (1, 2, 'full_name', 'Alohida maqomga ega mustaqil organ'),
  -- Russian translations
  (1, 3, 'full_name', 'MНезависимый орган с особым статусом');


INSERT INTO enum_government_organization_type
(id,order_number, short_name, full_name,state_id)
VALUES (3, '003', 'Прездент ва Админтрация хузуридаги ташкилот', 'Прездент ва Админтрация хузуридаги ташкилот',1);

INSERT INTO enum_government_organization_type_translate 
(owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (3, 1, 'full_name', 'Прездент ва Админтрация хузуридаги ташкилот'),
  -- Uzbek Latin translations
  (3, 2, 'full_name', 'Prezdent va Admintratsiya xuzuridagi tashkilot'),
  -- Russian translations
  (3, 3, 'full_name', 'Организация в присутствии президента и администрации');
  

  INSERT INTO enum_government_organization_type
(id,order_number, short_name, full_name,state_id)
VALUES (4, '004', 'Тижорат банклар жамгармалар ва бошқалар', 'Тижорат банклар жамгармалар ва бошқалар',1);

INSERT INTO enum_government_organization_type_translate 
(owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (4, 1, 'full_name', 'Тижорат банклар жамгармалар ва бошқалар'),
  -- Uzbek Latin translations
  (4, 2, 'full_name', 'Tijorat banklar jamgarmalar va boshqalar'),
  -- Russian translations
  (4, 3, 'full_name', 'Коммерческие банки, сберегательные кассы и т.д.');


  INSERT INTO enum_government_organization_type
(id,order_number, short_name, full_name,state_id)
VALUES (5, '005', 'Суд идоралари', 'Суд идоралари',1);

INSERT INTO enum_government_organization_type_translate 
(owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (5, 1, 'full_name', 'Суд идоралари'),
  -- Uzbek Latin translations
  (5, 2, 'full_name', 'Sud idoralari'),
  -- Russian translations
  (5, 3, 'full_name', 'Офисы суда');


  INSERT INTO enum_government_organization_type
(id,order_number, short_name, full_name,state_id)
VALUES (6, '006', 'Харбийлаштириш Тизимлари', 'Харбийлаштириш Тизимлари',1);

INSERT INTO enum_government_organization_type_translate 
(owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (6, 1, 'full_name', 'Харбийлаштириш Тизимлари'),
  -- Uzbek Latin translations
  (6, 2, 'full_name', 'Xarbiylashtirish Tizimlari'),
  -- Russian translations
  (6, 3, 'full_name', 'Системы милитаризации');


INSERT INTO enum_government_organization_type
(id,order_number, short_name, full_name,state_id)
VALUES (7, '007', 'Хо`жалик бирлашмалар ҳамда уюшмалар', 'Хо`жалик бирлашмалар ҳамда уюшмалар',1);

INSERT INTO enum_government_organization_type_translate 
(owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (7, 1, 'full_name', 'Хо`жалик бирлашмалар ҳамда уюшмалар'),
  -- Uzbek Latin translations
  (7, 2, 'full_name', 'Xo`jalik birlashmalar hamda uyushmalar'),
  -- Russian translations
  (7, 3, 'full_name', 'MЭкономические ассоциации и ассоциации');
