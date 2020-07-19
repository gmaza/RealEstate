import React, { useState, useRef } from 'react';
import {
    StyledAutocomplete,
    StyledOutlinedInput,
    FlexRow,
    FlexCol,
    StyledFormControl,
    StyledSelect,
    StyledButton,
} from '../globals';
import {
    AreaInputsContainer,
    FilterButton,
    AdvanceSearchContainer,
    SearchBarWrapper,
    SearchTitle,
} from './style';
import {
    TextField,
    Checkbox,
    InputAdornment,
    Container,
    Grid,
    Box,
} from '@material-ui/core';
import {
    CheckBox as CheckBoxIcon,
    CheckBoxOutlineBlank,
    Landscape,
} from '@material-ui/icons';
import {
    LocationIcon,
    DropdownIcon,
    PropertyTypeIcon,
    PropertyLayoutIcon,
    OwnershipTypeIcon,
    EnergyCertificateIcon,
    AreaIcon,
    OfferTypeIcon,
    FilterIcon,
    FilterCloseIcon,
} from '../icons';
import { RangeInput } from '../rangeInput';
import { useTheme } from '@material-ui/core/styles';
import { useHistory } from 'react-router-dom';

const icon = <CheckBoxOutlineBlank fontSize="small" />;
const checkedIcon = <CheckBoxIcon fontSize="small" />;

export const SearchBar = (props) => {
    const query = new URLSearchParams(window.location.search);
    const history = useHistory();
    console.log(query.get('offerType'));

    const [advanceFilterActive, setAdvanceFilterActive] = useState(false);
    const [advanceFilterMaxHeight, setAdvanceFilterMaxHeight] = useState(0);
    const [offerType, setOfferType] = useState(query.get('offerType') || '');
    const [propertyType, setPropertyType] = useState(
        query.get('propeprtyType') || ''
    );
    const [propertyLayouts, setPropeprtyLayouts] = useState();
    const [propertyConditions, setPropertyConditions] = useState();
    const [ownershipTypes, setOwnershipTypes] = useState();
    const [buildingTypes, setBuildingTypes] = useState();
    const [landTypes, setLandTypes] = useState();
    const [furnishings, setFurnishing] = useState();
    const [energyCertificates, setEnergyCertificates] = useState();

    const advancedFilterRef = useRef(null);
    const theme = useTheme();

    function getMultiSelectField(options, setState, placeholder, addOnIcon) {
        return (
            <StyledAutocomplete
                multiple
                options={options}
                disableCloseOnSelect
                popupIcon={<DropdownIcon />}
                getOptionLabel={(option) => option.name}
                renderOption={(option, { selected }) => (
                    <React.Fragment>
                        <Checkbox
                            icon={icon}
                            checkedIcon={checkedIcon}
                            style={{ marginRight: 8 }}
                            checked={selected}
                        />
                        {option.name}
                    </React.Fragment>
                )}
                renderInput={(params) => (
                    <TextField
                        {...params}
                        variant="outlined"
                        placeholder={placeholder}
                        InputProps={{
                            ...params.InputProps,
                            startAdornment: (
                                <>
                                    <InputAdornment position="start">
                                        {addOnIcon}
                                    </InputAdornment>
                                    {params.InputProps.startAdornment}
                                </>
                            ),
                        }}
                    />
                )}
                onChange={(event, newValue) => {
                    setState(newValue);
                }}
                ChipProps={{
                    color: 'primary',
                }}
            />
        );
    }

    function toggleAdvanceFilter() {
        if (advanceFilterActive) {
            setAdvanceFilterMaxHeight(0);
        } else {
            setAdvanceFilterMaxHeight(advancedFilterRef.current.scrollHeight);
            setTimeout(() => setAdvanceFilterMaxHeight('none'), 400);
        }

        setAdvanceFilterActive(!advanceFilterActive);
    }

    function searchClickHandler() {
        history.push(
            `search?offerType=${offerType}&propeprtyType=${propertyType}`
        );
    }

    return (
        <div>
            <SearchBarWrapper withBackground={props.withBackground}>
                {props.withBackground && (
                    <SearchTitle>
                        Search Properties in <span>Czechia</span>
                    </SearchTitle>
                )}
                <Container fixed>
                    <Grid id="search-container" container spacing={1}>
                        <Grid
                            container
                            direction="row"
                            wrap="nowrap"
                            item
                            xs={12}
                            lg={4}
                        >
                            <StyledOutlinedInput
                                placeholder="Address"
                                startAdornment={
                                    <InputAdornment>
                                        <LocationIcon />
                                    </InputAdornment>
                                }
                            />
                            <Box
                                component={FilterButton}
                                display={{ lg: 'none' }}
                                onClick={toggleAdvanceFilter}
                                style={{
                                    backgroundColor: advanceFilterActive
                                        ? '#0066FF'
                                        : '',
                                }}
                            >
                                {advanceFilterActive ? (
                                    <FilterCloseIcon />
                                ) : (
                                    <FilterIcon />
                                )}
                            </Box>
                        </Grid>

                        <Box
                            component={Grid}
                            item
                            lg={2}
                            display={{ xs: 'none', lg: 'block' }}
                        >
                            <StyledFormControl variant="outlined" fullWidth>
                                <StyledSelect
                                    native
                                    value={offerType}
                                    startAdornment={
                                        <InputAdornment>
                                            <OfferTypeIcon />
                                        </InputAdornment>
                                    }
                                    onChange={(event) =>
                                        setOfferType(event.target.value)
                                    }
                                    IconComponent={DropdownIcon}
                                >
                                    <option aria-label="None" value="" disabled>
                                        Offer Type
                                    </option>

                                    {props.lookupOptions.offerTypes.map(
                                        (opt) => (
                                            <option key={opt.id} value={opt.id}>
                                                {opt.name}
                                            </option>
                                        )
                                    )}
                                </StyledSelect>
                            </StyledFormControl>
                        </Box>

                        <Box
                            component={Grid}
                            item
                            lg={2}
                            display={{ xs: 'none', lg: 'block' }}
                        >
                            <StyledFormControl variant="outlined" fullWidth>
                                <StyledSelect
                                    native
                                    value={propertyType}
                                    startAdornment={
                                        <InputAdornment>
                                            <PropertyTypeIcon />
                                        </InputAdornment>
                                    }
                                    onChange={(event) =>
                                        setPropertyType(event.target.value)
                                    }
                                    IconComponent={DropdownIcon}
                                >
                                    <option aria-label="None" value="" disabled>
                                        Property Type
                                    </option>

                                    {props.lookupOptions.propertyTypes.map(
                                        (opt) => (
                                            <option key={opt.id} value={opt.id}>
                                                {opt.name}
                                            </option>
                                        )
                                    )}
                                </StyledSelect>
                            </StyledFormControl>
                        </Box>

                        <Box
                            component={Grid}
                            item
                            lg={2}
                            display={{ xs: 'none', lg: 'block' }}
                        >
                            <RangeInput></RangeInput>
                        </Box>

                        <Box
                            component={Grid}
                            item
                            lg={1}
                            display={{ xs: 'none', lg: 'block' }}
                        >
                            <StyledButton variant="secondary">
                                Agencies
                            </StyledButton>
                        </Box>
                        <Box
                            component={Grid}
                            item
                            lg={1}
                            display={{ xs: 'none', lg: 'block' }}
                        >
                            <StyledButton
                                variant="primary"
                                onClick={searchClickHandler}
                            >
                                Search
                            </StyledButton>
                        </Box>
                    </Grid>
                </Container>
            </SearchBarWrapper>

            <AdvanceSearchContainer
                open={advanceFilterActive}
                ref={advancedFilterRef}
                style={{ maxHeight: advanceFilterMaxHeight }}
            >
                <StyledFormControl variant="outlined" fullWidth>
                    <StyledSelect
                        native
                        value={offerType}
                        startAdornment={
                            <InputAdornment>
                                <OfferTypeIcon />
                            </InputAdornment>
                        }
                        onChange={(event) => setOfferType(event.target.value)}
                        IconComponent={DropdownIcon}
                    >
                        <option aria-label="None" value="none" disabled>
                            Offer Type
                        </option>

                        {props.lookupOptions.offerTypes.map((opt) => (
                            <option key={opt.id} value={opt.id}>
                                {opt.name}
                            </option>
                        ))}
                    </StyledSelect>
                </StyledFormControl>
                <StyledFormControl variant="outlined" fullWidth>
                    <StyledSelect
                        native
                        value={propertyType}
                        startAdornment={
                            <InputAdornment>
                                <PropertyTypeIcon />
                            </InputAdornment>
                        }
                        onChange={(event) =>
                            setPropertyType(event.target.value)
                        }
                        IconComponent={DropdownIcon}
                    >
                        <option aria-label="None" value="none" disabled>
                            Property Type
                        </option>

                        {props.lookupOptions.propertyTypes.map((opt) => (
                            <option key={opt.id} value={opt.id}>
                                {opt.name}
                            </option>
                        ))}
                    </StyledSelect>
                </StyledFormControl>

                {getMultiSelectField(
                    props.lookupOptions.propertyLayouts,
                    setPropeprtyLayouts,
                    'Property Layouts',
                    <PropertyLayoutIcon />
                )}

                <RangeInput></RangeInput>

                {getMultiSelectField(
                    props.lookupOptions.ownershipTypes,
                    setOwnershipTypes,
                    'Ownership Types',
                    <OwnershipTypeIcon />
                )}
                {getMultiSelectField(
                    props.lookupOptions.energyCertificates,
                    setEnergyCertificates,
                    'Energy Performance Certificates',
                    <EnergyCertificateIcon />
                )}
                {getMultiSelectField(
                    props.lookupOptions.landTypes,
                    setLandTypes,
                    'Land Types',
                    <Landscape />
                )}
                <AreaInputsContainer>
                    <StyledOutlinedInput
                        placeholder="Space From"
                        type="number"
                        startAdornment={
                            <InputAdornment>
                                <AreaIcon />
                            </InputAdornment>
                        }
                        endAdornment={
                            <InputAdornment>
                                m<sup>2</sup>
                            </InputAdornment>
                        }
                    />
                    <StyledOutlinedInput
                        placeholder="Space Up To"
                        type="number"
                        startAdornment={
                            <InputAdornment>
                                <AreaIcon />
                            </InputAdornment>
                        }
                        endAdornment={
                            <InputAdornment>
                                m<sup>2</sup>
                            </InputAdornment>
                        }
                    />
                </AreaInputsContainer>
                <Box
                    component={Grid}
                    mt="10px"
                    container
                    display="row"
                    wrap="nowrap"
                >
                    <Box mr="10px" component={StyledButton} variant="secondary">
                        Agency
                    </Box>
                    <StyledButton variant="primary">Search</StyledButton>
                </Box>
            </AdvanceSearchContainer>
        </div>
    );
};
