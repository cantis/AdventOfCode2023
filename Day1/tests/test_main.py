import pytest
from day1.main import calc_calebration, number_replace

testdata1 = [('1abc2', 12), ('pqr3stu8vwx', 38), ('a1b2c3d4e5f', 15), ('treb7uchet', 77)]


@pytest.mark.parametrize("input_string,expected_output", testdata1)
def test_calc_calebration(input_string: str, expected_output: int) -> None:
    # arrange

    # act
    result = calc_calebration(input_string)

    # assert
    assert result == expected_output

testdata2 = [('57threetwo', 52), ('9twobfknine57sixfour7', 97), ('fbndztsthreefourthreefgj1eightrffdbpsn', 38), ('four1rg8five', 45)]

@pytest.mark.parametrize("input_string,expected_output", testdata2)
def test_calc_calebration_with_string_numbers(input_string: str, expected_output: int) -> None:
    # arrange

    # act
    result = calc_calebration(input_string)

    # assert
    assert result == expected_output


def test_number_replace() -> None:
    # arrange
    input_string = 'fbndztsthreefourthreefgj1eightrffdbpsn'

    # act
    result = number_replace(input_string)

    # assert
    assert result == 'fbndzts343fgj18rffdbpsn'