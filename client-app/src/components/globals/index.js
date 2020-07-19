import styled from 'styled-components';
import {
    TextField,
    OutlinedInput,
    SvgIcon,
    FormControl,
    Select,
} from '@material-ui/core';
import { Autocomplete, Pagination } from '@material-ui/lab';

export const FlexRow = styled.div`
    display: flex;
    flex-direction: row;
    justify-content: flex-start;
    align-items: center;
`;

export const FlexCol = styled.div`
    display: flex;
    flex-direction: column;
    justify-content: flex-start;
    align-items: stretch;
`;

export const StyledTextField = styled(TextField)`
    .MuiTextField-root {
        background: #ffffff;
        .Mui-focused {
            .MuiOutlinedInput-notchedOutline {
                border-color: #004dff;
            }
        }
    }
`;

export const StyledAutocomplete = styled(Autocomplete)`
    .MuiTextField-root {
        background: #ffffff;
        border-color: #e8e8e8;
        .Mui-focused {
            .MuiOutlinedInput-notchedOutline {
                border-color: #004dff;
            }
        }
    }
`;

export const StyledOutlinedInput = styled(OutlinedInput)`
    &.MuiOutlinedInput-root {
        background: #ffffff;
        border-color: #e8e8e8;

        width: 100%;
        &.Mui-focused {
            .MuiOutlinedInput-notchedOutline {
                border-color: #004dff;
            }
        }
        .MuiOutlinedInput-inputAdornedStart {
            padding-left: inherit;
        }
    }
`;

export const StyledSvgIcon = styled(SvgIcon)`
    &.MuiSvgIcon-root {
        font-size: 1rem;
        height: auto;
        width: auto;
    }
`;

export const StyledPagination = styled(Pagination)``;

export const StyledFormControl = styled(FormControl)`
    &.MuiFormControl-root {
        margin: initial;
    }

    .MuiOutlinedInput-root {
        background: #ffffff;
        border-color: #e8e8e8;
    }
    &:hover {
        .MuiOutlinedInput-notchedOutline {
            border-color: #004dff;
        }
    }
`;

export const StyledSelect = styled(Select)`
    .MuiOutlinedInput-inputAdornedStart {
        padding-left: 10px;
    }

    .MuiSelect-select:focus {
        background: #ffffff;
    }

    .MuiSelect-icon {
        top: calc(50% - 3px);
    }
`;

export const StyledButton = styled.button`
    background-color: ${(props) =>
        props.variant === 'primary' ? '#004DFF' : '#D9E4FF'};
    color: ${(props) =>
        props.variant === 'primary' ? '#ffffff' : 'rgb(54,53,53, 0.5)'};
    height: 56px;
    text-transform: none;
    padding: 0 16px;
    cursor: pointer;
    border: 0;
    border-radius: 5px;
    width: 100%;
    font-style: normal;
    font-weight: ${(props) =>
        props.variant === 'primary' ? 'bold' : 'normal'};
    font-size: ${(props) => (props.variant === 'primary' ? '16px' : '14px')};
    outline: 0;
`;
