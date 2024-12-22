CREATE TABLE "Accounts"(
    "id" BIGINT NOT NULL,
    "user_name" VARCHAR(255) NOT NULL,
    "type_id" BIGINT NOT NULL,
    "email" VARCHAR(255) NOT NULL,
    "hashed_password" VARCHAR(255) NOT NULL,
    "path_to_profile_photo" VARCHAR(255) NOT NULL,
    "phone" VARCHAR(255) NOT NULL,
    "path_to_resume" VARCHAR(255) NOT NULL,
    "last_sign_in_date" DATE NOT NULL
);
ALTER TABLE
    "Accounts" ADD PRIMARY KEY("id");
ALTER TABLE
    "Accounts" ADD CONSTRAINT "accounts_user_name_unique" UNIQUE("user_name");
ALTER TABLE
    "Accounts" ADD CONSTRAINT "accounts_email_unique" UNIQUE("email");
ALTER TABLE
    "Accounts" ADD CONSTRAINT "accounts_hashed_password_unique" UNIQUE("hashed_password");
ALTER TABLE
    "Accounts" ADD CONSTRAINT "accounts_path_to_profile_photo_unique" UNIQUE("path_to_profile_photo");
ALTER TABLE
    "Accounts" ADD CONSTRAINT "accounts_path_to_resume_unique" UNIQUE("path_to_resume");
CREATE TABLE "Account_types"(
    "id" BIGINT NOT NULL,
    "type_name" VARCHAR(255) NOT NULL
);
ALTER TABLE
    "Account_types" ADD PRIMARY KEY("id");
CREATE TABLE "Person"(
    "account_id" BIGINT NOT NULL,
    "name" VARCHAR(255) NOT NULL,
    "surname" VARCHAR(255) NOT NULL,
    "father_name" VARCHAR(255) NOT NULL,
    "dob" DATE NOT NULL
);
ALTER TABLE
    "Person" ADD PRIMARY KEY("account_id");
CREATE TABLE "Achievements"(
    "account_id" BIGINT NOT NULL,
    "total_tests_count" BIGINT NOT NULL DEFAULT '0',
    "total_exercises_count" BIGINT NOT NULL DEFAULT '0',
    "total_articles_count" BIGINT NOT NULL DEFAULT '0'
);
ALTER TABLE
    "Achievements" ADD PRIMARY KEY("account_id");
CREATE TABLE "Articles"(
    "id" BIGINT NOT NULL,
    "title" VARCHAR(255) NOT NULL,
    "rating" BIGINT NOT NULL DEFAULT '0',
    "author_id" BIGINT NOT NULL,
    "first_paragraph" VARCHAR(255) NOT NULL,
    "path_to_file" VARCHAR(255) NOT NULL,
    "theme_id" BIGINT NOT NULL
);
ALTER TABLE
    "Articles" ADD PRIMARY KEY("id");
ALTER TABLE
    "Articles" ADD CONSTRAINT "articles_path_to_file_unique" UNIQUE("path_to_file");
COMMENT
ON COLUMN
    "Articles"."first_paragraph" IS 'will be shown as a preview, can be the first paragraph of the file or manually inserted';
CREATE TABLE "Tests"(
    "id" BIGINT NOT NULL,
    "title" VARCHAR(255) NOT NULL,
    "rating" BIGINT NOT NULL DEFAULT '0',
    "author_id" BIGINT NOT NULL,
    "path_to_file" VARCHAR(255) NOT NULL
);
ALTER TABLE
    "Tests" ADD PRIMARY KEY("id");
ALTER TABLE
    "Tests" ADD CONSTRAINT "tests_path_to_file_unique" UNIQUE("path_to_file");
CREATE TABLE "Vacancy"(
    "id" BIGINT NOT NULL,
    "title" VARCHAR(255) NOT NULL,
    "path_to_file" VARCHAR(255) NOT NULL,
    "hire_manager_id" BIGINT NOT NULL,
    "publish_date" DATE NOT NULL,
    "remove_date" DATE NOT NULL,
    "views" BIGINT NOT NULL DEFAULT '0'
);
ALTER TABLE
    "Vacancy" ADD PRIMARY KEY("id");
ALTER TABLE
    "Vacancy" ADD CONSTRAINT "vacancy_path_to_file_unique" UNIQUE("path_to_file");
CREATE TABLE "Article_themes"(
    "id" BIGINT NOT NULL,
    "name" VARCHAR(255) NOT NULL
);
ALTER TABLE
    "Article_themes" ADD PRIMARY KEY("id");
ALTER TABLE
    "Vacancy" ADD CONSTRAINT "vacancy_hire_manager_id_foreign" FOREIGN KEY("hire_manager_id") REFERENCES "Accounts"("id");
ALTER TABLE
    "Achievements" ADD CONSTRAINT "achievements_account_id_foreign" FOREIGN KEY("account_id") REFERENCES "Accounts"("id");
ALTER TABLE
    "Accounts" ADD CONSTRAINT "accounts_type_id_foreign" FOREIGN KEY("type_id") REFERENCES "Account_types"("id");
ALTER TABLE
    "Articles" ADD CONSTRAINT "articles_author_id_foreign" FOREIGN KEY("author_id") REFERENCES "Accounts"("id");
ALTER TABLE
    "Tests" ADD CONSTRAINT "tests_author_id_foreign" FOREIGN KEY("author_id") REFERENCES "Accounts"("id");
ALTER TABLE
    "Person" ADD CONSTRAINT "person_account_id_foreign" FOREIGN KEY("account_id") REFERENCES "Accounts"("id");
ALTER TABLE
    "Articles" ADD CONSTRAINT "articles_theme_id_foreign" FOREIGN KEY("theme_id") REFERENCES "Article_themes"("id");