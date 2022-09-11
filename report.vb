<<<<<<< HEAD
﻿Public MustInherit Class report
=======
﻿Option Strict On
Option Explicit On
Option Infer Off

Public Class report
>>>>>>> 17b94be3b5827feec808198643656002c93cb477
    Private _diseases As String
    Private _prevention As String


    Public Property diseases As String
        Get
            Return _diseases
        End Get
        Set(value As String)
            _diseases = value
        End Set
    End Property

    Public Property prevention As String
        Get
            Return _prevention
        End Get
        Set(value As String)
            _prevention = value
        End Set
    End Property

    Public MustOverride Function Disease() As String
    Public MustOverride Function Prevent() As String

    'The general format is this:

    'You're more likely to contract a <viral/bacterial/autoimmune> infection
    'Diseases to look out for included, but are not limited to:
    '<insert list of potential diseases> (look below)
    'Here a some steps to prevent it
    '<insert list>(look below)


    'Common diseases: Auto-Immune
    '   arthritis, multiple sclerosis, Type 1 diabetes, lupus, crohn's disease
    'Common diseases: Bacterial
    '   Strep Throat, Salmonella, Tuberculosis, STDs
    'Common diseases: Viral
    '   Cold, Flu, AIDS, Stomach Flu, Hepatitis



    'Prevention: Viral
    '   Eat healthily.
    '   Take your vitamins.
    '   Wash/ Sanitize your hands often
    '   get enough sleep

    'Prevention: Bacterial
    '   Avoid clse contact with sick people
    '   Cover coughs and sneezes
    '   Avoid touching your face
    '   Stay home if you are sick
    '   Clean and disinfect surfaces that are touched often
    '   Avoid contaminated food and water

    'Prevention: Autoimmune
    '   It may not be possible to prevent auto-immune diseases but do try to:
    '   Exercise consistently
    '   Stay away from cigarettes
    '   Avoid toxins
    '   Maintain a healthy diet
    '   Limit processed foods from your diet



    'Additional Notes to help with the coding

    'AutoImmune (Risk Factors to determine likelihood) :
    '    Some medications. (if meds = true then...)
    '    Having relatives With autoimmune diseases. (if sickFam = true...)
    '    Smoking. (if smoker = true...)
    '    Already having one autoimmune disease. (if sick = true then...)
    '    Being female — 78% Of people who have an autoimmune disease are women. (if gender = "Female" then...)
    '    Obesity. (if (bmi < 30) and (bmi > 39.9) then...)

    'Viral (Risk Factors to determine likelihood) : 
    '   Smoking. (if smoker = true...)
    '   Not Washing Hands Enough. (if waterQual = true...)
    '   Crowded Areas (if overcrowded = true...)
    '   Health Conditions. (if sick = true...)
    '   Age (if (age < 13) or (age > 65) = true...)
    '   Stress (if stress = true...)
    '   (If HIVPos = true...)
    '   (if acoholic = true...) {can lead to risky sexual behaviour}
    '   (if sActive = true...)
    '   (if drugs = true...)

    'Bacterial (Risk Factors to determine likelihood) :
    '   pre-existing conditions (if sick = true then....)
    '   (if HIVPos = true...)
    '   (if sActive = true...)
    '   (if drugs = true...)
    '   (If waterQual = true...)
    '   (if overcrowded = true...)
    '   (if stress = true...)
    '   (if bmi < 18.5 then...)

End Class
